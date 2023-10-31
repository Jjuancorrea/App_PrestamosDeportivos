using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class clsConexion
    {
        public SqlConnection connection = new SqlConnection("Data Source=AP-SE105-16\\SQLEXPRESS;Initial Catalog=dbs_prestamos_deportivos;Integrated Security=True");
    }
}
