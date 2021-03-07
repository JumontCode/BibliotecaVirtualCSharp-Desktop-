
namespace SistemaBibliotecaVirtualSBV
{
    partial class FormPrestamo
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
            this.components = new System.ComponentModel.Container();
            this.dgvPrestamo = new System.Windows.Forms.DataGridView();
            this.eMPRESTIMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButSairEmp = new System.Windows.Forms.Button();
            this.ButGravarEmp = new System.Windows.Forms.Button();
            this.ButcanEmp = new System.Windows.Forms.Button();
            this.ButEditarEmp = new System.Windows.Forms.Button();
            this.ButRemoverEmp = new System.Windows.Forms.Button();
            this.ButNonoEmp = new System.Windows.Forms.Button();
            this.lblIDEmp = new System.Windows.Forms.Label();
            this.lblCliEmp = new System.Windows.Forms.Label();
            this.lblDataEmp = new System.Windows.Forms.Label();
            this.DtpEmp = new System.Windows.Forms.DateTimePicker();
            this.textBoxEmp = new System.Windows.Forms.TextBox();
            this.cbbNomprePrestamo = new System.Windows.Forms.ComboBox();
            this.lblEmp = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.ButGravarLivro = new System.Windows.Forms.Button();
            this.ButCancLivro = new System.Windows.Forms.Button();
            this.ButNovoLivro = new System.Windows.Forms.Button();
            this.LblIDLivro = new System.Windows.Forms.Label();
            this.LblLivro = new System.Windows.Forms.Label();
            this.LblEntrega = new System.Windows.Forms.Label();
            this.DtpLivro = new System.Windows.Forms.DateTimePicker();
            this.textBoxIdLivro = new System.Windows.Forms.TextBox();
            this.cbbLibro = new System.Windows.Forms.ComboBox();
            this.LblItemID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESTIMOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrestamo
            // 
            this.dgvPrestamo.AutoGenerateColumns = false;
            this.dgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamo.DataSource = this.eMPRESTIMOBindingSource;
            this.dgvPrestamo.GridColor = System.Drawing.Color.White;
            this.dgvPrestamo.Location = new System.Drawing.Point(450, 35);
            this.dgvPrestamo.Name = "dgvPrestamo";
            this.dgvPrestamo.RowHeadersWidth = 51;
            this.dgvPrestamo.Size = new System.Drawing.Size(404, 132);
            this.dgvPrestamo.TabIndex = 13;
            // 
            // eMPRESTIMOBindingSource
            // 
            this.eMPRESTIMOBindingSource.DataMember = "EMPRESTIMO";
            // 
            // ButSairEmp
            // 
            this.ButSairEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButSairEmp.Location = new System.Drawing.Point(316, 173);
            this.ButSairEmp.Margin = new System.Windows.Forms.Padding(2);
            this.ButSairEmp.Name = "ButSairEmp";
            this.ButSairEmp.Size = new System.Drawing.Size(81, 31);
            this.ButSairEmp.TabIndex = 12;
            this.ButSairEmp.Text = "&Salir";
            this.ButSairEmp.UseVisualStyleBackColor = true;
            // 
            // ButGravarEmp
            // 
            this.ButGravarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButGravarEmp.Location = new System.Drawing.Point(316, 132);
            this.ButGravarEmp.Margin = new System.Windows.Forms.Padding(2);
            this.ButGravarEmp.Name = "ButGravarEmp";
            this.ButGravarEmp.Size = new System.Drawing.Size(81, 35);
            this.ButGravarEmp.TabIndex = 11;
            this.ButGravarEmp.Text = "&Guardar";
            this.ButGravarEmp.UseVisualStyleBackColor = true;
            // 
            // ButcanEmp
            // 
            this.ButcanEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButcanEmp.Location = new System.Drawing.Point(177, 173);
            this.ButcanEmp.Margin = new System.Windows.Forms.Padding(2);
            this.ButcanEmp.Name = "ButcanEmp";
            this.ButcanEmp.Size = new System.Drawing.Size(83, 31);
            this.ButcanEmp.TabIndex = 10;
            this.ButcanEmp.Text = "&Cancelar";
            this.ButcanEmp.UseVisualStyleBackColor = true;
            // 
            // ButEditarEmp
            // 
            this.ButEditarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButEditarEmp.Location = new System.Drawing.Point(177, 132);
            this.ButEditarEmp.Margin = new System.Windows.Forms.Padding(2);
            this.ButEditarEmp.Name = "ButEditarEmp";
            this.ButEditarEmp.Size = new System.Drawing.Size(83, 35);
            this.ButEditarEmp.TabIndex = 9;
            this.ButEditarEmp.Text = "&Editar";
            this.ButEditarEmp.UseVisualStyleBackColor = true;
            // 
            // ButRemoverEmp
            // 
            this.ButRemoverEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButRemoverEmp.Location = new System.Drawing.Point(36, 173);
            this.ButRemoverEmp.Margin = new System.Windows.Forms.Padding(2);
            this.ButRemoverEmp.Name = "ButRemoverEmp";
            this.ButRemoverEmp.Size = new System.Drawing.Size(85, 31);
            this.ButRemoverEmp.TabIndex = 8;
            this.ButRemoverEmp.Text = "&Eliminar";
            this.ButRemoverEmp.UseVisualStyleBackColor = true;
            // 
            // ButNonoEmp
            // 
            this.ButNonoEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButNonoEmp.Location = new System.Drawing.Point(36, 132);
            this.ButNonoEmp.Margin = new System.Windows.Forms.Padding(2);
            this.ButNonoEmp.Name = "ButNonoEmp";
            this.ButNonoEmp.Size = new System.Drawing.Size(85, 35);
            this.ButNonoEmp.TabIndex = 7;
            this.ButNonoEmp.Text = "&Nuevo";
            this.ButNonoEmp.UseVisualStyleBackColor = true;
            // 
            // lblIDEmp
            // 
            this.lblIDEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDEmp.Location = new System.Drawing.Point(123, 20);
            this.lblIDEmp.Name = "lblIDEmp";
            this.lblIDEmp.Size = new System.Drawing.Size(124, 20);
            this.lblIDEmp.TabIndex = 6;
            // 
            // lblCliEmp
            // 
            this.lblCliEmp.AutoSize = true;
            this.lblCliEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliEmp.Location = new System.Drawing.Point(59, 55);
            this.lblCliEmp.Name = "lblCliEmp";
            this.lblCliEmp.Size = new System.Drawing.Size(62, 20);
            this.lblCliEmp.TabIndex = 5;
            this.lblCliEmp.Text = "Cliente:";
            // 
            // lblDataEmp
            // 
            this.lblDataEmp.AutoSize = true;
            this.lblDataEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEmp.Location = new System.Drawing.Point(73, 93);
            this.lblDataEmp.Name = "lblDataEmp";
            this.lblDataEmp.Size = new System.Drawing.Size(48, 20);
            this.lblDataEmp.TabIndex = 4;
            this.lblDataEmp.Text = "Data:";
            // 
            // DtpEmp
            // 
            this.DtpEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEmp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpEmp.Location = new System.Drawing.Point(127, 93);
            this.DtpEmp.MaxDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.DtpEmp.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.DtpEmp.Name = "DtpEmp";
            this.DtpEmp.Size = new System.Drawing.Size(100, 26);
            this.DtpEmp.TabIndex = 3;
            this.DtpEmp.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // textBoxEmp
            // 
            this.textBoxEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmp.Location = new System.Drawing.Point(343, 55);
            this.textBoxEmp.Name = "textBoxEmp";
            this.textBoxEmp.Size = new System.Drawing.Size(101, 26);
            this.textBoxEmp.TabIndex = 2;
            // 
            // cbbNomprePrestamo
            // 
            this.cbbNomprePrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNomprePrestamo.FormattingEnabled = true;
            this.cbbNomprePrestamo.Location = new System.Drawing.Point(127, 55);
            this.cbbNomprePrestamo.Name = "cbbNomprePrestamo";
            this.cbbNomprePrestamo.Size = new System.Drawing.Size(210, 28);
            this.cbbNomprePrestamo.TabIndex = 1;
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.Location = new System.Drawing.Point(5, 20);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(123, 20);
            this.lblEmp.TabIndex = 0;
            this.lblEmp.Text = "PRESTAMO ID:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.SlateGray;
            this.splitContainer1.Panel1.Controls.Add(this.dgvPrestamo);
            this.splitContainer1.Panel1.Controls.Add(this.ButSairEmp);
            this.splitContainer1.Panel1.Controls.Add(this.ButGravarEmp);
            this.splitContainer1.Panel1.Controls.Add(this.ButcanEmp);
            this.splitContainer1.Panel1.Controls.Add(this.ButEditarEmp);
            this.splitContainer1.Panel1.Controls.Add(this.ButRemoverEmp);
            this.splitContainer1.Panel1.Controls.Add(this.ButNonoEmp);
            this.splitContainer1.Panel1.Controls.Add(this.lblIDEmp);
            this.splitContainer1.Panel1.Controls.Add(this.lblCliEmp);
            this.splitContainer1.Panel1.Controls.Add(this.lblDataEmp);
            this.splitContainer1.Panel1.Controls.Add(this.DtpEmp);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxEmp);
            this.splitContainer1.Panel1.Controls.Add(this.cbbNomprePrestamo);
            this.splitContainer1.Panel1.Controls.Add(this.lblEmp);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.SlateGray;
            this.splitContainer1.Panel2.Controls.Add(this.dgvLibros);
            this.splitContainer1.Panel2.Controls.Add(this.ButGravarLivro);
            this.splitContainer1.Panel2.Controls.Add(this.ButCancLivro);
            this.splitContainer1.Panel2.Controls.Add(this.ButNovoLivro);
            this.splitContainer1.Panel2.Controls.Add(this.LblIDLivro);
            this.splitContainer1.Panel2.Controls.Add(this.LblLivro);
            this.splitContainer1.Panel2.Controls.Add(this.LblEntrega);
            this.splitContainer1.Panel2.Controls.Add(this.DtpLivro);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxIdLivro);
            this.splitContainer1.Panel2.Controls.Add(this.cbbLibro);
            this.splitContainer1.Panel2.Controls.Add(this.LblItemID);
            this.splitContainer1.Size = new System.Drawing.Size(884, 461);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvLibros
            // 
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(469, 31);
            this.dgvLibros.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersWidth = 51;
            this.dgvLibros.RowTemplate.Height = 24;
            this.dgvLibros.Size = new System.Drawing.Size(376, 178);
            this.dgvLibros.TabIndex = 44;
            // 
            // ButGravarLivro
            // 
            this.ButGravarLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButGravarLivro.Location = new System.Drawing.Point(319, 174);
            this.ButGravarLivro.Margin = new System.Windows.Forms.Padding(2);
            this.ButGravarLivro.Name = "ButGravarLivro";
            this.ButGravarLivro.Size = new System.Drawing.Size(81, 35);
            this.ButGravarLivro.TabIndex = 43;
            this.ButGravarLivro.Text = "Guar&dar";
            this.ButGravarLivro.UseVisualStyleBackColor = true;
            // 
            // ButCancLivro
            // 
            this.ButCancLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButCancLivro.Location = new System.Drawing.Point(180, 178);
            this.ButCancLivro.Margin = new System.Windows.Forms.Padding(2);
            this.ButCancLivro.Name = "ButCancLivro";
            this.ButCancLivro.Size = new System.Drawing.Size(83, 31);
            this.ButCancLivro.TabIndex = 42;
            this.ButCancLivro.Text = "Gu&ardar";
            this.ButCancLivro.UseVisualStyleBackColor = true;
            // 
            // ButNovoLivro
            // 
            this.ButNovoLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButNovoLivro.Location = new System.Drawing.Point(39, 174);
            this.ButNovoLivro.Margin = new System.Windows.Forms.Padding(2);
            this.ButNovoLivro.Name = "ButNovoLivro";
            this.ButNovoLivro.Size = new System.Drawing.Size(85, 35);
            this.ButNovoLivro.TabIndex = 41;
            this.ButNovoLivro.Text = "N&uevo";
            this.ButNovoLivro.UseVisualStyleBackColor = true;
            // 
            // LblIDLivro
            // 
            this.LblIDLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIDLivro.Location = new System.Drawing.Point(126, 40);
            this.LblIDLivro.Name = "LblIDLivro";
            this.LblIDLivro.Size = new System.Drawing.Size(124, 20);
            this.LblIDLivro.TabIndex = 40;
            // 
            // LblLivro
            // 
            this.LblLivro.AutoSize = true;
            this.LblLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLivro.Location = new System.Drawing.Point(69, 75);
            this.LblLivro.Name = "LblLivro";
            this.LblLivro.Size = new System.Drawing.Size(48, 20);
            this.LblLivro.TabIndex = 39;
            this.LblLivro.Text = "Libro:";
            // 
            // LblEntrega
            // 
            this.LblEntrega.AutoSize = true;
            this.LblEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEntrega.Location = new System.Drawing.Point(55, 113);
            this.LblEntrega.Name = "LblEntrega";
            this.LblEntrega.Size = new System.Drawing.Size(70, 20);
            this.LblEntrega.TabIndex = 38;
            this.LblEntrega.Text = "Entrega:";
            // 
            // DtpLivro
            // 
            this.DtpLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpLivro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpLivro.Location = new System.Drawing.Point(126, 110);
            this.DtpLivro.MaxDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.DtpLivro.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.DtpLivro.Name = "DtpLivro";
            this.DtpLivro.Size = new System.Drawing.Size(100, 26);
            this.DtpLivro.TabIndex = 37;
            this.DtpLivro.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // textBoxIdLivro
            // 
            this.textBoxIdLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdLivro.Location = new System.Drawing.Point(342, 73);
            this.textBoxIdLivro.Name = "textBoxIdLivro";
            this.textBoxIdLivro.Size = new System.Drawing.Size(101, 26);
            this.textBoxIdLivro.TabIndex = 36;
            // 
            // cbbLibro
            // 
            this.cbbLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLibro.FormattingEnabled = true;
            this.cbbLibro.Location = new System.Drawing.Point(126, 73);
            this.cbbLibro.Name = "cbbLibro";
            this.cbbLibro.Size = new System.Drawing.Size(210, 28);
            this.cbbLibro.TabIndex = 35;
            // 
            // LblItemID
            // 
            this.LblItemID.AutoSize = true;
            this.LblItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItemID.Location = new System.Drawing.Point(61, 40);
            this.LblItemID.Name = "LblItemID";
            this.LblItemID.Size = new System.Drawing.Size(66, 20);
            this.LblItemID.TabIndex = 34;
            this.LblItemID.Text = "Item ID:";
            // 
            // FormAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 525);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormAutor";
            this.Text = "FormPrestamo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESTIMOBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPrestamo;
        private System.Windows.Forms.BindingSource eMPRESTIMOBindingSource;
        private System.Windows.Forms.Button ButSairEmp;
        private System.Windows.Forms.Button ButGravarEmp;
        private System.Windows.Forms.Button ButcanEmp;
        private System.Windows.Forms.Button ButEditarEmp;
        private System.Windows.Forms.Button ButRemoverEmp;
        private System.Windows.Forms.Button ButNonoEmp;
        private System.Windows.Forms.Label lblIDEmp;
        private System.Windows.Forms.Label lblCliEmp;
        private System.Windows.Forms.Label lblDataEmp;
        private System.Windows.Forms.DateTimePicker DtpEmp;
        private System.Windows.Forms.TextBox textBoxEmp;
        private System.Windows.Forms.ComboBox cbbNomprePrestamo;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Button ButGravarLivro;
        private System.Windows.Forms.Button ButCancLivro;
        private System.Windows.Forms.Button ButNovoLivro;
        private System.Windows.Forms.Label LblIDLivro;
        private System.Windows.Forms.Label LblLivro;
        private System.Windows.Forms.Label LblEntrega;
        private System.Windows.Forms.DateTimePicker DtpLivro;
        private System.Windows.Forms.TextBox textBoxIdLivro;
        private System.Windows.Forms.ComboBox cbbLibro;
        private System.Windows.Forms.Label LblItemID;
    }
}