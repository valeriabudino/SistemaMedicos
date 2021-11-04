
namespace WindowsMedicos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNroMatricula = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.cbEspecialidades = new System.Windows.Forms.ComboBox();
            this.gridMedicoEspecialidad = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicoEspecialidad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(157, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(157, 122);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 26);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNroMatricula
            // 
            this.txtNroMatricula.Location = new System.Drawing.Point(380, 122);
            this.txtNroMatricula.Name = "txtNroMatricula";
            this.txtNroMatricula.Size = new System.Drawing.Size(100, 26);
            this.txtNroMatricula.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(370, 182);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 36);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(153, 267);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(165, 20);
            this.lblEspecialidad.TabIndex = 4;
            this.lblEspecialidad.Text = "Traer por especialidad";
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(350, 264);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(121, 28);
            this.cbEspecialidad.TabIndex = 5;
            this.cbEspecialidad.SelectionChangeCommitted += new System.EventHandler(this.cbEspecialidad_SelectionChangeCommitted);
            // 
            // cbEspecialidades
            // 
            this.cbEspecialidades.FormattingEnabled = true;
            this.cbEspecialidades.Location = new System.Drawing.Point(370, 60);
            this.cbEspecialidades.Name = "cbEspecialidades";
            this.cbEspecialidades.Size = new System.Drawing.Size(121, 28);
            this.cbEspecialidades.TabIndex = 6;
            this.cbEspecialidades.SelectionChangeCommitted += new System.EventHandler(this.cbEspecialidades_SelectionChangeCommitted);
            // 
            // gridMedicoEspecialidad
            // 
            this.gridMedicoEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedicoEspecialidad.Location = new System.Drawing.Point(39, 314);
            this.gridMedicoEspecialidad.Name = "gridMedicoEspecialidad";
            this.gridMedicoEspecialidad.RowHeadersWidth = 62;
            this.gridMedicoEspecialidad.RowTemplate.Height = 28;
            this.gridMedicoEspecialidad.Size = new System.Drawing.Size(728, 297);
            this.gridMedicoEspecialidad.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.gridMedicoEspecialidad);
            this.Controls.Add(this.cbEspecialidades);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNroMatricula);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicoEspecialidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNroMatricula;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.ComboBox cbEspecialidades;
        private System.Windows.Forms.DataGridView gridMedicoEspecialidad;
    }
}

