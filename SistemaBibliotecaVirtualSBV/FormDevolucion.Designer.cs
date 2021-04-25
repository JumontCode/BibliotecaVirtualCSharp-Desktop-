
namespace SistemaBibliotecaVirtualSBV
{
    partial class FormDevolucion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDevolucion));
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblNumeroPrestamo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblEntrega = new System.Windows.Forms.Label();
            this.dateTimeEntrega = new System.Windows.Forms.DateTimePicker();
            this.btnSelecPrestamo = new System.Windows.Forms.Button();
            this.lblIdLibro = new System.Windows.Forms.Label();
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(223, 300);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(241, 98);
            this.txtObservacion.TabIndex = 2;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(36, 48);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(77, 40);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDevolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDevolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnDevolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDevolver.Image = ((System.Drawing.Image)(resources.GetObject("btnDevolver.Image")));
            this.btnDevolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolver.Location = new System.Drawing.Point(223, 404);
            this.btnDevolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(241, 38);
            this.btnDevolver.TabIndex = 3;
            this.btnDevolver.Text = "Devolver Libro";
            this.btnDevolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(75, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(432, 36);
            this.label4.TabIndex = 297;
            this.label4.Text = "FORMULARIO DEVOLUCION";
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.lblEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.ForeColor = System.Drawing.Color.White;
            this.lblEmp.Location = new System.Drawing.Point(13, 189);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(204, 20);
            this.lblEmp.TabIndex = 296;
            this.lblEmp.Text = "NUMERO DE PRESTAMO:";
            // 
            // lblNumeroPrestamo
            // 
            this.lblNumeroPrestamo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNumeroPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumeroPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPrestamo.ForeColor = System.Drawing.Color.Black;
            this.lblNumeroPrestamo.Location = new System.Drawing.Point(223, 189);
            this.lblNumeroPrestamo.Name = "lblNumeroPrestamo";
            this.lblNumeroPrestamo.Size = new System.Drawing.Size(64, 20);
            this.lblNumeroPrestamo.TabIndex = 298;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 305;
            this.label1.Text = "Observación:";
            // 
            // LblEntrega
            // 
            this.LblEntrega.AutoSize = true;
            this.LblEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.LblEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEntrega.ForeColor = System.Drawing.Color.White;
            this.LblEntrega.Location = new System.Drawing.Point(77, 245);
            this.LblEntrega.Name = "LblEntrega";
            this.LblEntrega.Size = new System.Drawing.Size(140, 20);
            this.LblEntrega.TabIndex = 303;
            this.LblEntrega.Text = "Fecha Devolución:";
            // 
            // dateTimeEntrega
            // 
            this.dateTimeEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEntrega.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimeEntrega.Location = new System.Drawing.Point(223, 245);
            this.dateTimeEntrega.MaxDate = new System.DateTime(2060, 12, 31, 0, 0, 0, 0);
            this.dateTimeEntrega.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimeEntrega.Name = "dateTimeEntrega";
            this.dateTimeEntrega.Size = new System.Drawing.Size(241, 26);
            this.dateTimeEntrega.TabIndex = 1;
            this.dateTimeEntrega.Value = new System.DateTime(2021, 3, 12, 0, 0, 0, 0);
            // 
            // btnSelecPrestamo
            // 
            this.btnSelecPrestamo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSelecPrestamo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelecPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecPrestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnSelecPrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnSelecPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecPrestamo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelecPrestamo.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecPrestamo.Image")));
            this.btnSelecPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecPrestamo.Location = new System.Drawing.Point(453, 48);
            this.btnSelecPrestamo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelecPrestamo.Name = "btnSelecPrestamo";
            this.btnSelecPrestamo.Size = new System.Drawing.Size(112, 40);
            this.btnSelecPrestamo.TabIndex = 4;
            this.btnSelecPrestamo.Text = "Seleccionar Prestamo";
            this.btnSelecPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecPrestamo.UseVisualStyleBackColor = false;
            this.btnSelecPrestamo.Click += new System.EventHandler(this.btnSelecPrestamo_Click);
            // 
            // lblIdLibro
            // 
            this.lblIdLibro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIdLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIdLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdLibro.ForeColor = System.Drawing.Color.Black;
            this.lblIdLibro.Location = new System.Drawing.Point(302, 189);
            this.lblIdLibro.Name = "lblIdLibro";
            this.lblIdLibro.Size = new System.Drawing.Size(64, 20);
            this.lblIdLibro.TabIndex = 298;
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(26)))));
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(578, 21);
            this.panelCabecera.TabIndex = 320;
            this.panelCabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabecera_MouseDown);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHistorial.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorial.Image")));
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Location = new System.Drawing.Point(333, 48);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(112, 40);
            this.btnHistorial.TabIndex = 321;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // FormDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(578, 466);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.panelCabecera);
            this.Controls.Add(this.btnSelecPrestamo);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.lblIdLibro);
            this.Controls.Add(this.lblNumeroPrestamo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblEntrega);
            this.Controls.Add(this.dateTimeEntrega);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDevolucion";
            this.Text = "FormDevolucion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDevolucion_FormClosing);
            this.Load += new System.EventHandler(this.FormDevolucion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblEntrega;
        private System.Windows.Forms.DateTimePicker dateTimeEntrega;
        private System.Windows.Forms.Button btnSelecPrestamo;
        public System.Windows.Forms.Label lblNumeroPrestamo;
        public System.Windows.Forms.Label lblIdLibro;
        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Button btnHistorial;
    }
}