using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAlumnasInframor.Models.Dao
{
    public class DbContext
    {
        protected SqlConnection conexion;
        public DbContext()
        {
            conexion = new SqlConnection("Server=MSI ;DataBase=InstitutoBD ;Integrated Security=True ");
        }
    }
}
