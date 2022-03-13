using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolka
{
    enum Floor
    {
        male, feemale
    }

    class Person
    {

        public static List<Person> persons = new List<Person>();

        private static int idcounter = 0;

        public string image { get; private set; }

        public string diagnoz { get; private set; }

        public int id { get; private set; }

        public string name { get; private set; }

        public string sername { get; private set; }

        public DateTime burthday { get; private set; }

        public Floor floor { get; private set; }

        public Person ( string name, string surname, DateTime burthday, Floor floor, string image, string diagnoz)
        {
            this.diagnoz = diagnoz;
            this.image = image;
            this.id = idcounter++;
            this.name = name;
            this.sername = surname;
            this.burthday = burthday;
            this.floor = floor;
        }

    }
}
