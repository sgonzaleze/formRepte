using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerRepte_GonzalezSergio
{
    public class Fichero
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public DateTime Date { get; set; }
    
     
     
        public Fichero(String Id, String Name, DateTime Date)
        {
            this.Id = Id;
            this.Name = Name;
            this.Date = Date;

        }

        public Fichero()
        {

        }
    }
}
