
namespace SistemaBibliotecaVirtualSBV
{
    partial class FormSeleccionarPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeleccionarPrestamo));
            this.btnBuscarPrestamo = new System.Windows.Forms.Button();
            this.txtBuscarPrestamo = new System.Windows.Forms.TextBox();
            this.btnSelecPrestamo = new System.Windows.Forms.Button();
            this.dataGridPrestamoLibros = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrestamoLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarPrestamo
            // 
            this.btnBuscarPrestamo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarPrestamo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPrestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnBuscarPrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnBuscarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPrestamo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarPrestamo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPrestamo.Image")));
            this.btnBuscarPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPrestamo.Location = new System.Drawing.Point(433, 91);
            this.btnBuscarPrestamo.Name = "btnBuscarPrestamo";
            this.btnBuscarPrestamo.Size = new System.Drawing.Size(34, 20);
            this.btnBuscarPrestamo.TabIndex = 325;
            this.btnBuscarPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPrestamo.UseVisualStyleBackColor = false;
            this.btnBuscarPrestamo.Click += new System.EventHandler(this.btnBuscarPrestamo_Click);
            // 
            // txtBuscarPrestamo
            // 
            this.txtBuscarPrestamo.Location = new System.Drawing.Point(37, 91);
            this.txtBuscarPrestamo.Name = "txtBuscarPrestamo";
            this.txtBuscarPrestamo.Size = new System.Drawing.Size(396, 20);
            this.txtBuscarPrestamo.TabIndex = 324;
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
            this.btnSelecPrestamo.Location = new System.Drawing.Point(37, 508);
            this.btnSelecPrestamo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelecPrestamo.Name = "btnSelecPrestamo";
            this.btnSelecPrestamo.Size = new System.Drawing.Size(430, 24);
            this.btnSelecPrestamo.TabIndex = 323;
            this.btnSelecPrestamo.Text = "Seleccionar Prestamo";
            this.btnSelecPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecPrestamo.UseVisualStyleBackColor = false;
            this.btnSelecPrestamo.Click += new System.EventHandler(this.btnSelecPrestamo_Click);
            // 
            // dataGridPrestamoLibros
            // 
            this.dataGridPrestamoLibros.AllowUserToAddRows = false;
            this.dataGridPrestamoLibros.AllowUserToDeleteRows = false;
            this.dataGridPrestamoLibros.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridPrestamoLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPrestamoLibros.Location = new System.Drawing.Point(37, 112);
            this.dataGridPrestamoLibros.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridPrestamoLibros.Name = "dataGridPrestamoLibros";
            this.dataGridPrestamoLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPrestamoLibros.Size = new System.Drawing.Size(430, 396);
            this.dataGridPrestamoLibros.TabIndex = 322;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(391, 36);
            this.label4.TabIndex = 326;
            this.label4.Text = "SELECCIONAR PRESTAMO";
            // 
            // FormSeleccionarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(509, 541);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscarPrestamo);
            this.Controls.Add(this.txtBuscarPrestamo);
            this.Controls.Add(this.btnSelecPrestamo);
            this.Controls.Add(this.dataGridPrestamoLibros);
            this.MaximumSize = new System.Drawing.Size(525, 580);
            this.MinimumSize = new System.Drawing.Size(525, 580);
            this.Name = "FormSeleccionarPrestamo";
            this.Text = "FormSeleccionarPrestamo";
            this.Load += new System.EventHandler(this.FormSeleccionarPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrestamoLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarPrestamo;
        private System.Windows.Forms.TextBox txtBuscarPrestamo;
        private System.Windows.Forms.Button btnSelecPrestamo;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridPrestamoLibros;
    }
}