using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSK_2_MD
{
    class InsertQueries
    {
        private Dictionary<int, string> insertQueries = new Dictionary<int, string>();
        private Dictionary<int, string> listQueries = new Dictionary<int, string>();

        public Dictionary<int, string> InsertQueriesMap { get => insertQueries; }
        public Dictionary<int, string> ListQueries { get => listQueries; }

        public InsertQueries()
        {
            this.FillInsertQueriesDictionary();
            this.FillList();
        }

        private void FillInsertQueriesDictionary()
        {
            insertQueries.Add(0, "ALTER TABLE ZABIEGI DROP COLUMN potrzebny_sprzet;");
            insertQueries.Add(1, "INSERT INTO SZPITALE VALUES('Mazowiecki Szpital Ogólny' ,124313719, 'ul. Jakaś 8, 03-242 Warszawa', 0 );");
            insertQueries.Add(2, "INSERT INTO ODDZIALY VALUES('Ortopedyczny',7, 'Mazowiecki Szpital Brodnowski', 1);");
            insertQueries.Add(3, "DELETE FROM ODDZIALY WHERE nazwaOdzialu = 'Ortopedyczny';");
            insertQueries.Add(4, "UPDATE SZPITALE SET telefon = 987124313 WHERE nazwa = 'Mazowiecki Szpital Ogólny';");
        }

        private void FillList()
        {
            listQueries.Add(0, "ALTER ZABIEGI");
            listQueries.Add(1, "INSERT into SZPITALE");
            listQueries.Add(2, "INSERT into ODDZIALY");
            listQueries.Add(3, "DELETE from ODDZIALY");
            listQueries.Add(4, "UPDATE in SZPITALE");
        }
    }
}
