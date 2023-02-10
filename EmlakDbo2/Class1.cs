using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmlakDbo2
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-HD11C8A\SQLEXPRESS;Initial Catalog=emlakdbo;Integrated Security=True; Persist Security Info = False");
            baglan.Open();
            return baglan;
        }
    }
}
