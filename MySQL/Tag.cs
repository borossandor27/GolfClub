using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL
{
    class Tag
    {
        readonly int id;
        readonly string nev;
        readonly DateTime szuletett;

        public Tag(int id, string nev, DateTime szuletett)
        {
            this.id = id;
            this.nev = nev;
            this.szuletett = szuletett;
        }

        public int Id => id;

        public string Nev => nev;

        public DateTime Szuletett => szuletett;

        public override string ToString()
        {
            return nev + szuletett.ToString(", (yyyy-MM-dd)");
        }
    }
}
