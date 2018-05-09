create database GestioneMenu;
use GestioneMenu;
create table Portate(
	id int identity(1,1) primary key, 
	descrizione nvarchar(50)	
);
create table Piatti(
	id int identity(1,1) primary key,
	portata int foreign key references Portate, 
	descrizione nvarchar(50)	
);
create table FasciaOrario(
	id int identity(1,1) primary key,
	descrizione nvarchar(50)	
);
create table Giorni(
	id int identity(1,1) primary key, 
	dataGiorno date unique,
);
create table Menu(
	id int identity(1,1) primary key,
	descrizione nvarchar(50)	
);
create table MenuPiatti(
	id int identity(1,1) primary key,
	menu int foreign key references Menu, 
	piatto int foreign key references Piatti,
	unique(menu,piatto)	
);
create table GiorniMenu(
	id int identity(1,1) primary key,
	menu int foreign key references Menu, 
	giorno int foreign key references Giorni,
	fasciaOrario int foreign key references FasciaOrario,
	unique(menu,giorno,fasciaOrario)	
);
create procedure AddMenu
	@nomeMenu nvarchar(50),
	@data date,
	@primo nvarchar(50),
	@secondo nvarchar(50),
	@contorno nvarchar(50),
	@dolce nvarchar(50)
as
	set implicit_transactions on;
	begin try
		insert into Giorni(dataGiorno) values(@data);
		declare @idG int = ident_current('Giorni');
		insert into Menu(descrizione) values(@nomeMenu);
		declare @idM int = ident_current('Menu');
		
	end try 
go
