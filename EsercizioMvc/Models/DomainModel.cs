using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EsercizioMvc.Models {
    interface IDomainModel {
        void Add(Menu menu);
        List<Menu> GetListMenu();
        Menu GetMenu(string nameMenu);
    }

    public class Menu {
        private string nome;
        private string fasciaOrario;
        private List<Piatto> piatti;
        private DateTime data;

        public Menu(string nome, DateTime data, string fasciaOrario, List<Piatto> list) {
            this.Nome = nome;
            this.fasciaOrario = fasciaOrario;
            this.Piatti = list;
            this.Data=data;
        }

        public string Nome { get => nome; set => nome = value; }
        public string FasciaOrario { get => fasciaOrario; set => fasciaOrario = value; }
        public List<Piatto> Piatti { get => piatti; set => piatti = value; }
        public DateTime Data { get => data; set => data = value; }
    }

    public class DomainModel : IDomainModel {
        public void Add(Menu menu) {
            return;
        }

        public List<Menu> GetListMenu() {
            return new List<Menu>(){ new Menu("prova1",DateTime.Now,"Pranzo", new List<Piatto>(){new Piatto("pasta", (Portata)0),new Piatto("pasta", (Portata)1),new Piatto("pasta", (Portata)2),new Piatto("pasta", (Portata)3)  }), new Menu("prova2",DateTime.Now, "cena", new List<Piatto>() {
                new Piatto("pasta", (Portata)0),new Piatto("pasta", (Portata)1),new Piatto("pasta", (Portata)2),new Piatto("pasta", (Portata)3) })
                 ,new Menu("prova1",DateTime.Now,"Pranzo", new List<Piatto>(){new Piatto("pasta", (Portata)0), new Piatto("pasta", (Portata)1),new Piatto("pasta", (Portata)2),new Piatto("pasta", (Portata)3)  })};
        }

        public Menu GetMenu(string nameMenu) {
            return new Menu("prova1", DateTime.Now, "Pranzo", new List<Piatto>() { new Piatto("pasta", (Portata)0) });
        }
    }
    public enum Portata { Primo, Secondo, Contorno, Dolce}
    public class Piatto {
        private string nome;
        private Portata portata;
        public Piatto(string nome,  Portata portata) {
            this.Nome = nome;
            this.Portata = portata;
        }

        public string Nome { get => nome; set => nome = value; }
        public Portata Portata { get => portata; set => portata = value; }
    }
}