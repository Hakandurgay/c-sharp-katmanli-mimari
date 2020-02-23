using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FacadeLayer
{
  public  class SqlBaglantisi
    {
        public static SqlConnection baglanti = new SqlConnection(@"Data Source=HAKAN\SQLEXPRESS;Initial Catalog=MYUdemy1;Integrated Security=True");

    }
}
