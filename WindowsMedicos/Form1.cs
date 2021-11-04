using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades.Models;

namespace WindowsMedicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarMedicos();
            llenarCombo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtNroMatricula.Text), Convert.ToInt32(cbEspecialidades.SelectedValue));

            int filasAfectadas = AdminMedico.Insertar(medico);

            if (filasAfectadas > 0)
            {
                mostrarMedicos();
            }

            // limpiar cajitas
            limpiarTextBoxs();
        }

        private void limpiarTextBoxs()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtNroMatricula.Clear();
        }

        private void cbEspecialidades_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cbEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int especialidadId = Convert.ToInt32(cbEspecialidad.SelectedValue);

            if (especialidadId == 0)
            {
                mostrarMedicos();
            }
            else
            {
                gridMedicoEspecialidad.DataSource = AdminMedico.Listar(especialidadId);
            }

        }

        private void mostrarMedicos()
        {
            gridMedicoEspecialidad.DataSource = AdminMedico.Listar();
        }

        private void llenarCombo()
        {
            DataTable Especialidad = AdminEspecialidad.Listar();
            DataTable Especialidades = AdminEspecialidad.Listar();

            cbEspecialidad.DataSource = Especialidad;
            cbEspecialidad.DisplayMember = Especialidad.Columns["Nombre"].ToString();
            cbEspecialidad.ValueMember = Especialidad.Columns["Id"].ToString();

            DataRow fila = Especialidad.NewRow();
            fila["Id"] = 0;
            fila["Nombre"] = "[TODAS]"; Especialidad.Rows.InsertAt(fila, 0);

            // Combo especialidades para guardar un medico
            cbEspecialidades.DataSource = Especialidades;
            cbEspecialidades.DisplayMember = Especialidades.Columns["Nombre"].ToString();
            cbEspecialidades.ValueMember = Especialidades.Columns["Id"].ToString();
        }
    }
}
