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
    public static class AdminMedico
    {
        public static List<Medico> Listar()
        {
            string consultaSQL = "SELECT Id,Nombre,Apellido,NroMatricula,EspecialidadId FROM dbo.Medico";

            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConetarDB());

            SqlDataReader reader;

            reader = comando.ExecuteReader();

            List<Medico> lista = new List<Medico>();

            while (reader.Read())
            {
                lista.Add(
                    new Medico()
                    { 
                        Id = (int)reader["Id"],
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        NroMatricula = (int)reader["NroMatricula"],
                        EspecialidadId = (int)reader["EspecialidadId"],
                    }
                    );
            }
            AdminDB.ConetarDB().Close();
            reader.Close();
            return lista;

        }
        public static DataTable Listar(int idEspecialidad)
        {
            string consultaSLQ = "SELECT Id,Nombre,Apellido,NroMatricula,EspecialidadId FROM dbo.Medico WHERE EspecialidadId = @EspecialidadId";
      
            SqlDataAdapter adapter = new SqlDataAdapter(consultaSLQ, AdminDB.ConetarDB());
           
            adapter.SelectCommand.Parameters.Add("@EspecialidadId", SqlDbType.Int).Value = idEspecialidad;
           
            DataSet ds = new DataSet();
            
            adapter.Fill(ds, "EspecialidadId");

            return ds.Tables["EspecialidadId"];
        }
        public static DataTable TraerUno(int idEspecialidad)
        {
            string consultaSLQ = "SELECT Id,Nombre,Apellido,NroMatricula,EspecialidadId FROM dbo.Medico WHERE Id = @Id";

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSLQ, AdminDB.ConetarDB());

            adapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = idEspecialidad;

            DataSet ds = new DataSet();

            adapter.Fill(ds, "Id");

            return ds.Tables["Id"];
        }
        public static int Insertar(Medico medico)
        {
            string insertSQL = "INSERT dbo.Medico(Nombre, Apellido,NroMatricula,EspecialidadId) VALUES(@Nombre, @Apellido, @NroMatricula,@EspecialidadId)";
            SqlCommand command = new SqlCommand(insertSQL, AdminDB.ConetarDB());
            command.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = medico.Nombre;
            command.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = medico.Apellido;
            command.Parameters.Add("@NroMatricula", SqlDbType.Int).Value = medico.NroMatricula;
            command.Parameters.Add("@EspecialidadId", SqlDbType.Int).Value = medico.EspecialidadId;

            int filasAfectadas = command.ExecuteNonQuery();
            AdminDB.ConetarDB().Close();

            return filasAfectadas;
        }
        public static int Eliminar(int id)
        {
            string consulta = "DELETE FROM dbo.Medico WHERE Id = @Id";

            SqlDataAdapter adapter = new SqlDataAdapter(consulta, AdminDB.ConetarDB());

            adapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            int filasAfectadas = adapter.SelectCommand.ExecuteNonQuery();

            AdminDB.ConetarDB().Close();
            return filasAfectadas;
        }

        public static int Modificar(Medico medico)
        {
            string consulta = "UPDATE dbo.Medico SET Nombre = @Nombre ,Apellido = @Apellido,NroMatricula = @NroMatricula, EspecialidadId = @EspecialidadId WHERE Id = @Id";


            SqlDataAdapter adapter = new SqlDataAdapter(consulta, AdminDB.ConetarDB());
            adapter.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = medico.Nombre;
            adapter.SelectCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = medico.Apellido;
            adapter.SelectCommand.Parameters.Add("@NroMatricula", SqlDbType.Int).Value = medico.NroMatricula;
            adapter.SelectCommand.Parameters.Add("@EspecialidadId", SqlDbType.Int, 50).Value = medico.EspecialidadId;
            adapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = medico.Id;

            int filasAfectadas = adapter.SelectCommand.ExecuteNonQuery();

            AdminDB.ConetarDB().Close();
            return filasAfectadas;
        }

    }
}
