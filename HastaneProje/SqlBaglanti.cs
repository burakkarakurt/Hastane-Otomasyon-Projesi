using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneProje
{
    class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source = (localdb)\\burak; Initial Catalog = HastaneProje; Integrated Security = True");
            baglan.Open();//Formlardan çağırdığımızda açık olarak gelsin.
            return baglan;
        }
    }
}
