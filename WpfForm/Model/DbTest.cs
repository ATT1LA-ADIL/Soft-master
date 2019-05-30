using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
namespace Программное_обеспечение_для_Диспетчеров_Службы_Спасения.WpfForm.Model
{

    public class Aplication 
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public string MiddleName { get; set; }

        public string Adress { get; set; }

        public string Problem { get; set; }
        public Boolean Status { get; set; }
        public DateTime DateCreate { get; set; } = DateTime.Now;
    }

    class DbTest : DbContext
    {
        public DbTest() : base("DbConnection")
        {
            
        }
        public DbSet<Aplication> Aplication { get; set; }



    }
}
