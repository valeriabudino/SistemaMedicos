using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Models;

namespace Datos
{
    public static class AdminEspecialidad
    {
        public static DataTable Listar()
        {
            string consultaSLQ = "SELECT Id,Nombre FROM dbo.Especialidad";

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSLQ, AdminDB.ConetarDB());

            DataSet ds = new DataSet();

            adapter.Fill(ds, "Especialidades");

            return ds.Tables["Especialidades"];
        }

        public static DataTable TraerUno(int id)
        {
            string consultaSLQ = "SELECT Id,Nombre FROM dbo.Especialidad WHERE Id = @Id";

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSLQ, AdminDB.ConetarDB());

            adapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            DataSet ds = new DataSet();

            adapter.Fill(ds, "Id");

            return ds.Tables["Id"];
        }

        public static int Insertar(Especialidad especialidad)
        {
            string insertSQL = "INSERT dbo.Especialidad(Nombre) VALUES(@Nombre)";
            SqlCommand command = new SqlCommand(insertSQL, AdminDB.ConetarDB());
            command.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = especialidad.Nombre;

            int filasAfectadas = command.ExecuteNonQuery();
            AdminDB.ConetarDB().Close();

            return filasAfectadas;
        }

    }
}
