using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using Entidades.Models;

namespace WebMedicos
{
    public partial class WebFrmMedicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarMedicos();
            llenarCombo();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int especialidadId = Convert.ToInt32(dropEspecialidades.SelectedValue);

            Medico medico = new Medico(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtMatricula.Text), especialidadId);
         
            int filasAfectadas = AdminMedico.Insertar(medico);
            if (filasAfectadas > 0)
            {
                mostrarMedicos();
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            int especialidadId = Convert.ToInt32(dropEspecialidades.SelectedValue);

            Medico medico = new Medico(Convert.ToInt32(txtId.Text),txtNombre.Text,txtApellido.Text,Convert.ToInt32(txtMatricula.Text) ,especialidadId);

            int filasAfectadas = AdminMedico.Modificar(medico);

            if (filasAfectadas > 0)
            {
                mostrarMedicos();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            int filasAfectadas = AdminMedico.Eliminar(id);
            if (filasAfectadas > 0)
            {
                mostrarMedicos();
            }

        }

        protected void dropEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int especialidadId = Convert.ToInt32(dropEspecialidad.SelectedValue);

            if (especialidadId == 0)
            {
                mostrarMedicos();
            }
            else
            {
                grid.DataSource = AdminMedico.Listar(especialidadId);
                grid.DataBind();

            }
        }

        private void mostrarMedicos()
        {
            grid.DataSource = AdminMedico.Listar();
            grid.DataBind();
        }

        private void llenarCombo()
        {
            DataTable Especialidad = AdminEspecialidad.Listar();
            DataTable Especialidades = AdminEspecialidad.Listar();

            dropEspecialidad.DataSource = Especialidad;
            dropEspecialidad.DataTextField = Especialidad.Columns["Nombre"].ToString();
            dropEspecialidad.DataValueField = Especialidad.Columns["Id"].ToString();
            dropEspecialidad.DataBind();

            DataRow fila = Especialidad.NewRow();
            fila["Id"] = 0;
            fila["Nombre"] = "[TODAS]"; Especialidad.Rows.InsertAt(fila, 0);

            // Combo especialidades para guardar un medico
            dropEspecialidades.DataSource = Especialidades;
            dropEspecialidades.DataTextField = Especialidades.Columns["Nombre"].ToString();
            dropEspecialidades.DataValueField = Especialidades.Columns["Id"].ToString();
            dropEspecialidades.DataBind();
        }
    }
}