using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EsercizioMvc.Models {
    interface IDAO {
        void Add(Menu menu);
        List<Menu> GetListMenu();
        Menu GetMenu(string nameMenu);
    }
    public class DAO : IDAO {
        public GestioneMenuEntities db;
        public void Add(Menu menu) {
            using(db = new GestioneMenuEntities()) {
                db.Menu
            }
        }

        public List<Menu> GetListMenu() {
            throw new NotImplementedException();
        }

        public Menu GetMenu(string nameMenu) {
            throw new NotImplementedException();
        }
    }
}