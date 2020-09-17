using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSK_2_MD
{
    class SelectQueries
    {
        private Dictionary<int, string> selectQueries = new Dictionary<int, string>();
        private Dictionary<int, string> listQueries = new Dictionary<int, string>();

        public Dictionary<int, string> SelectQueriesMap { get => selectQueries; }
        public Dictionary<int, string> ListQueries { get => listQueries; }

        public SelectQueries()
        {
            this.FillSelectQueriesDictionary();
            this.FillList();
        }

        private void FillSelectQueriesDictionary()
        {
            selectQueries.Add(0, "Select * from ZABIEGI");
            selectQueries.Add(1, "Select * from TRANSPORTY");
            selectQueries.Add(2, "Select * from SZPITALE");
            selectQueries.Add(3, "Select * from ODDZIALY");
            selectQueries.Add(4, "Select * from SALE_ZABIEGOWE");
            selectQueries.Add(5, "Select * from KARETKI");
            selectQueries.Add(6, "Select * from CHOROBY");
            selectQueries.Add(7, "Select * from PACJENCI");
            selectQueries.Add(8, "Select * from POBYT");
            selectQueries.Add(9, "Select * from LEKARZE");
            selectQueries.Add(10, "Select * from BTPOBYT_LEKARZE");
            selectQueries.Add(11, "Select * from RECEPTY");
        }

        private void FillList()
        {
            listQueries.Add(0, "ZABIEGI");
            listQueries.Add(1, "TRANSPORTY");
            listQueries.Add(2, "SZPITALE");
            listQueries.Add(3, "ODDZIALY");
            listQueries.Add(4, "SALE_ZABIEGOWE");
            listQueries.Add(5, "KARETKI");
            listQueries.Add(6, "CHOROBY");
            listQueries.Add(7, "PACJENCI");
            listQueries.Add(8, "POBYT");
            listQueries.Add(9, "LEKARZE");
            listQueries.Add(10, "BTPOBYT_LEKARZE");
            listQueries.Add(11, "RECEPTY");
        }
    }
}
