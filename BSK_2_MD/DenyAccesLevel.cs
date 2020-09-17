using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSK_2_MD
{
    public class DenyAccesLevel
    {
        public static List<string> FillDenyList0(string username)
        {
            List<string> denyList = new List<string>();
            return denyList;
        }

        public static List<string> FillDenyList1(string username)
        {
            List<string> denyList = new List<string>();
            denyList.Add(String.Format("deny ALTER on object::dbo.SZPITALE to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.CHOROBY to {0};", username));

            denyList.Add(String.Format("deny DELETE on object::dbo.SZPITALE to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.CHOROBY to {0};", username));

            denyList.Add(String.Format("deny INSERT on object::dbo.SZPITALE to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.CHOROBY to {0};", username));

            denyList.Add(String.Format("deny UPDATE on object::dbo.SZPITALE to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.CHOROBY to {0};", username));

            return denyList;

        }

        public static List<string> FillDenyList2(string username)
        {
            
            List<string> denyList = new List<string>();
            denyList.Add(String.Format("deny ALTER on object::dbo.SZPITALE to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.CHOROBY to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.ODDZIALY to {0};", username));

            denyList.Add(String.Format("deny DELETE on object::dbo.SZPITALE to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.CHOROBY to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.ODDZIALY to {0};", username));

            denyList.Add(String.Format("deny INSERT on object::dbo.SZPITALE to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.CHOROBY to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.ODDZIALY to {0};", username));

            denyList.Add(String.Format("deny UPDATE on object::dbo.SZPITALE to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.CHOROBY to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.ODDZIALY to {0};", username));
            return denyList;
        }

        public static List<string> FillDenyList3(string username)
        {
            
            List<string> denyList = new List<string>();
            denyList.Add(String.Format("deny ALTER on object::dbo.SZPITALE to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.CHOROBY to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.ODDZIALY to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.SALE_ZABIEGOWE to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.ZABIEGI to {0}; ", username));

            denyList.Add(String.Format("deny DELETE on object::dbo.SZPITALE to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.CHOROBY to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.ODDZIALY to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.SALE_ZABIEGOWE to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.ZABIEGI to {0}; ", username));

            denyList.Add(String.Format("deny INSERT on object::dbo.SZPITALE to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.CHOROBY to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.ODDZIALY to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.SALE_ZABIEGOWE to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.ZABIEGI to {0}; ", username));

            denyList.Add(String.Format("deny UPDATE on object::dbo.SZPITALE to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.CHOROBY to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.ODDZIALY to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.SALE_ZABIEGOWE to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.ZABIEGI to {0}; ", username));

            return denyList;
        }

        public static List<string> FillDenyList4(string username)
        {

            List<string> denyList = new List<string>();
            denyList.Add(String.Format("deny ALTER on object::dbo.SZPITALE to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.CHOROBY to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.ODDZIALY to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.SALE_ZABIEGOWE to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.ZABIEGI to {0}; ", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.KARETKI to {0}; ", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.LEKARZE to {0}; ", username));

            denyList.Add(String.Format("deny DELETE on object::dbo.SZPITALE to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.CHOROBY to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.ODDZIALY to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.SALE_ZABIEGOWE to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.ZABIEGI to {0}; ", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.KARETKI to {0}; ", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.LEKARZE to {0}; ", username));

            denyList.Add(String.Format("deny INSERT on object::dbo.SZPITALE to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.CHOROBY to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.ODDZIALY to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.SALE_ZABIEGOWE to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.ZABIEGI to {0}; ", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.KARETKI to {0}; ", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.LEKARZE to {0}; ", username));

            denyList.Add(String.Format("deny UPDATE on object::dbo.SZPITALE to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.CHOROBY to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.ODDZIALY to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.SALE_ZABIEGOWE to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.ZABIEGI to {0}; ", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.KARETKI to {0}; ", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.LEKARZE to {0}; ", username));
            return denyList;
        }

        public static List<string> FillDenyListAll(string username)
        {
            List<string> denyList = new List<string>();
            denyList.Add(String.Format("deny ALTER on object::dbo.ODDZIALY to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.SALE_ZABIEGOWE to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.KARETKI to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.ZABIEGI to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.PACJENCI to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.POBYT to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.LEKARZE to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.BTPOBYT_LEKARZE to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.TRANSPORTY to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.RECEPTY to {0};", username));

            denyList.Add(String.Format("deny DELETE on object::dbo.ODDZIALY to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.SALE_ZABIEGOWE to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.KARETKI to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.ZABIEGI to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.PACJENCI to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.POBYT to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.LEKARZE to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.BTPOBYT_LEKARZE to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.TRANSPORTY to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.RECEPTY to {0};", username));

            denyList.Add(String.Format("deny INSERT on object::dbo.ODDZIALY to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.SALE_ZABIEGOWE to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.KARETKI to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.ZABIEGI to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.PACJENCI to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.POBYT to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.LEKARZE to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.BTPOBYT_LEKARZE to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.TRANSPORTY to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.RECEPTY to {0};", username));

            denyList.Add(String.Format("deny UPDATE on object::dbo.ODDZIALY to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.SALE_ZABIEGOWE to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.KARETKI to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.ZABIEGI to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.PACJENCI to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.POBYT to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.LEKARZE to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.BTPOBYT_LEKARZE to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.TRANSPORTY to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.RECEPTY to {0};", username));

            denyList.Add(String.Format("deny ALTER on object::dbo.SZPITALE to {0};", username));
            denyList.Add(String.Format("deny ALTER on object::dbo.CHOROBY to {0};", username));

            denyList.Add(String.Format("deny DELETE on object::dbo.SZPITALE to {0};", username));
            denyList.Add(String.Format("deny DELETE on object::dbo.CHOROBY to {0};", username));

            denyList.Add(String.Format("deny INSERT on object::dbo.SZPITALE to {0};", username));
            denyList.Add(String.Format("deny INSERT on object::dbo.CHOROBY to {0};", username));

            denyList.Add(String.Format("deny UPDATE on object::dbo.SZPITALE to {0};", username));
            denyList.Add(String.Format("deny UPDATE on object::dbo.CHOROBY to {0};", username));

            return denyList;
        }

        public static List<string> DenyAccess(string username, int clearence_lvl)
        {
            switch (clearence_lvl)
            {
                case 0:
                    return FillDenyList0(username);
                case 1:
                    return FillDenyList1(username);
                case 2:
                    return FillDenyList2(username);
                case 3:
                    return FillDenyList3(username);
                case 4:
                    return FillDenyList3(username);
                default:
                    return FillDenyListAll(username);
            }
        }
    }
}
