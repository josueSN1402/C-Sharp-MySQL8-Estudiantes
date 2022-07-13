namespace SistemaColegio
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
            this.components = new System.ComponentModel.Container();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.AutoGenerateColumns = false;
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniDataGridViewTextBoxColumn,
            this.apaternoDataGridViewTextBoxColumn,
            this.amaternoDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.cursosDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.nota1DataGridViewTextBoxColumn,
            this.nota2DataGridViewTextBoxColumn,
            this.nota3DataGridViewTextBoxColumn});
            this.dgvEstudiantes.DataSource = this.estudianteBindingSource;
            this.dgvEstudiantes.Location = new System.Drawing.Point(74, 178);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.Size = new System.Drawing.Size(582, 228);
            this.dgvEstudiantes.TabIndex = 0;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // apaternoDataGridViewTextBoxColumn
            // 
            this.apaternoDataGridViewTextBoxColumn.DataPropertyName = "Apaterno";
            this.apaternoDataGridViewTextBoxColumn.HeaderText = "Apaterno";
            this.apaternoDataGridViewTextBoxColumn.Name = "apaternoDataGridViewTextBoxColumn";
            // 
            // amaternoDataGridViewTextBoxColumn
            // 
            this.amaternoDataGridViewTextBoxColumn.DataPropertyName = "Amaterno";
            this.amaternoDataGridViewTextBoxColumn.HeaderText = "Amaterno";
            this.amaternoDataGridViewTextBoxColumn.Name = "amaternoDataGridViewTextBoxColumn";
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            // 
            // cursosDataGridViewTextBoxColumn
            // 
            this.cursosDataGridViewTextBoxColumn.DataPropertyName = "Cursos";
            this.cursosDataGridViewTextBoxColumn.HeaderText = "Cursos";
            this.cursosDataGridViewTextBoxColumn.Name = "cursosDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // nota1DataGridViewTextBoxColumn
            // 
            this.nota1DataGridViewTextBoxColumn.DataPropertyName = "Nota1";
            this.nota1DataGridViewTextBoxColumn.HeaderText = "Nota1";
            this.nota1DataGridViewTextBoxColumn.Name = "nota1DataGridViewTextBoxColumn";
            // 
            // nota2DataGridViewTextBoxColumn
            // 
            this.nota2DataGridViewTextBoxColumn.DataPropertyName = "Nota2";
            this.nota2DataGridViewTextBoxColumn.HeaderText = "Nota2";
            this.nota2DataGridViewTextBoxColumn.Name = "nota2DataGridViewTextBoxColumn";
            // 
            // nota3DataGridViewTextBoxColumn
            // 
            this.nota3DataGridViewTextBoxColumn.DataPropertyName = "Nota3";
            this.nota3DataGridViewTextBoxColumn.HeaderText = "Nota3";
            this.nota3DataGridViewTextBoxColumn.Name = "nota3DataGridViewTextBoxColumn";
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataSource = typeof(SistemaColegio.Estudiante);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.dgvEstudiantes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota3DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
    }
}

