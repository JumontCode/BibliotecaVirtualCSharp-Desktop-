
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrestamo));
            this.eMPRESTIMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNumeroPrestamo = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.LblIDLivro = new System.Windows.Forms.Label();
            this.Elector = new System.Windows.Forms.Label();
            this.LblEntrega = new System.Windows.Forms.Label();
            this.dateTimeEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtCodigoElector = new System.Windows.Forms.TextBox();
            this.LblItemID = new System.Windows.Forms.Label();
            this.dataGridLibros = new System.Windows.Forms.DataGridView();
            this.dataGridLectores = new System.Windows.Forms.DataGridView();
            this.txtCodigoLibro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbEdicion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeSalida = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSelecElector = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSelecLibro = new System.Windows.Forms.Button();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.txtElector = new System.Windows.Forms.TextBox();
            this.txtBuscarLibro = new System.Windows.Forms.TextBox();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.btnBuscarElector = new System.Windows.Forms.Button();
            this.txtBuscarElector = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESTIMOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLectores)).BeginInit();
            this.SuspendLayout();
            // 
            // eMPRESTIMOBindingSource
            // 
            this.eMPRESTIMOBindingSource.DataMember = "EMPRESTIMO";
            // 
            // lblNumeroPrestamo
            // 
            this.lblNumeroPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPrestamo.ForeColor = System.Drawing.Color.White;
            this.lblNumeroPrestamo.Location = new System.Drawing.Point(146, 65);
            this.lblNumeroPrestamo.Name = "lblNumeroPrestamo";
            this.lblNumeroPrestamo.Size = new System.Drawing.Size(124, 20);
            this.lblNumeroPrestamo.TabIndex = 6;
            this.lblNumeroPrestamo.Text = "Aqui van los datos";
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.lblEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.ForeColor = System.Drawing.Color.White;
            this.lblEmp.Location = new System.Drawing.Point(28, 65);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(123, 20);
            this.lblEmp.TabIndex = 0;
            this.lblEmp.Text = "PRESTAMO ID:";
            // 
            // LblIDLivro
            // 
            this.LblIDLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIDLivro.Location = new System.Drawing.Point(76, 225);
            this.LblIDLivro.Name = "LblIDLivro";
            this.LblIDLivro.Size = new System.Drawing.Size(124, 20);
            this.LblIDLivro.TabIndex = 50;
            // 
            // Elector
            // 
            this.Elector.AutoSize = true;
            this.Elector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.Elector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Elector.ForeColor = System.Drawing.Color.White;
            this.Elector.Location = new System.Drawing.Point(12, 261);
            this.Elector.Name = "Elector";
            this.Elector.Size = new System.Drawing.Size(63, 20);
            this.Elector.TabIndex = 49;
            this.Elector.Text = "Elector:";
            // 
            // LblEntrega
            // 
            this.LblEntrega.AutoSize = true;
            this.LblEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.LblEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEntrega.ForeColor = System.Drawing.Color.White;
            this.LblEntrega.Location = new System.Drawing.Point(17, 383);
            this.LblEntrega.Name = "LblEntrega";
            this.LblEntrega.Size = new System.Drawing.Size(70, 20);
            this.LblEntrega.TabIndex = 48;
            this.LblEntrega.Text = "Entrega:";
            // 
            // dateTimeEntrega
            // 
            this.dateTimeEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEntrega.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimeEntrega.Location = new System.Drawing.Point(88, 380);
            this.dateTimeEntrega.MaxDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateTimeEntrega.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimeEntrega.Name = "dateTimeEntrega";
            this.dateTimeEntrega.Size = new System.Drawing.Size(305, 26);
            this.dateTimeEntrega.TabIndex = 47;
            this.dateTimeEntrega.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // txtCodigoElector
            // 
            this.txtCodigoElector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoElector.Location = new System.Drawing.Point(292, 258);
            this.txtCodigoElector.Name = "txtCodigoElector";
            this.txtCodigoElector.Size = new System.Drawing.Size(101, 26);
            this.txtCodigoElector.TabIndex = 46;
            // 
            // LblItemID
            // 
            this.LblItemID.AutoSize = true;
            this.LblItemID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.LblItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItemID.ForeColor = System.Drawing.Color.White;
            this.LblItemID.Location = new System.Drawing.Point(11, 225);
            this.LblItemID.Name = "LblItemID";
            this.LblItemID.Size = new System.Drawing.Size(66, 20);
            this.LblItemID.TabIndex = 44;
            this.LblItemID.Text = "Item ID:";
            // 
            // dataGridLibros
            // 
            this.dataGridLibros.AllowUserToAddRows = false;
            this.dataGridLibros.AllowUserToDeleteRows = false;
            this.dataGridLibros.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLibros.Location = new System.Drawing.Point(430, 71);
            this.dataGridLibros.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridLibros.Name = "dataGridLibros";
            this.dataGridLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLibros.Size = new System.Drawing.Size(430, 180);
            this.dataGridLibros.TabIndex = 271;
            // 
            // dataGridLectores
            // 
            this.dataGridLectores.AllowUserToAddRows = false;
            this.dataGridLectores.AllowUserToDeleteRows = false;
            this.dataGridLectores.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridLectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLectores.Location = new System.Drawing.Point(430, 318);
            this.dataGridLectores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridLectores.Name = "dataGridLectores";
            this.dataGridLectores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLectores.Size = new System.Drawing.Size(430, 198);
            this.dataGridLectores.TabIndex = 272;
            // 
            // txtCodigoLibro
            // 
            this.txtCodigoLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoLibro.Location = new System.Drawing.Point(292, 101);
            this.txtCodigoLibro.Name = "txtCodigoLibro";
            this.txtCodigoLibro.Size = new System.Drawing.Size(101, 26);
            this.txtCodigoLibro.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Libro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 274;
            this.label2.Text = "Edicion:";
            // 
            // cbbEdicion
            // 
            this.cbbEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEdicion.FormattingEnabled = true;
            this.cbbEdicion.Location = new System.Drawing.Point(77, 151);
            this.cbbEdicion.Name = "cbbEdicion";
            this.cbbEdicion.Size = new System.Drawing.Size(210, 28);
            this.cbbEdicion.TabIndex = 273;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 276;
            this.label3.Text = "Salida:";
            // 
            // dateTimeSalida
            // 
            this.dateTimeSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeSalida.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimeSalida.Location = new System.Drawing.Point(88, 331);
            this.dateTimeSalida.MaxDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateTimeSalida.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimeSalida.Name = "dateTimeSalida";
            this.dateTimeSalida.Size = new System.Drawing.Size(305, 26);
            this.dateTimeSalida.TabIndex = 275;
            this.dateTimeSalida.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(294, 466);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 24);
            this.btnCancelar.TabIndex = 285;
            this.btnCancelar.Text = "Actualizar ";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(83, 466);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 24);
            this.btnGuardar.TabIndex = 283;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnSelecElector
            // 
            this.btnSelecElector.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSelecElector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelecElector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecElector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnSelecElector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnSelecElector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecElector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecElector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelecElector.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecElector.Image")));
            this.btnSelecElector.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecElector.Location = new System.Drawing.Point(430, 522);
            this.btnSelecElector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelecElector.Name = "btnSelecElector";
            this.btnSelecElector.Size = new System.Drawing.Size(430, 24);
            this.btnSelecElector.TabIndex = 282;
            this.btnSelecElector.Text = "Seleccionar Elector";
            this.btnSelecElector.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecElector.UseVisualStyleBackColor = false;
            this.btnSelecElector.Click += new System.EventHandler(this.btnSelecElector_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(274, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "FORMULARIO PRESTAMO DE LIBROS";
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
            this.btnVolver.Location = new System.Drawing.Point(28, 21);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(77, 27);
            this.btnVolver.TabIndex = 286;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnSelecLibro
            // 
            this.btnSelecLibro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSelecLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelecLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnSelecLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnSelecLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelecLibro.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecLibro.Image")));
            this.btnSelecLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecLibro.Location = new System.Drawing.Point(430, 257);
            this.btnSelecLibro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelecLibro.Name = "btnSelecLibro";
            this.btnSelecLibro.Size = new System.Drawing.Size(430, 24);
            this.btnSelecLibro.TabIndex = 287;
            this.btnSelecLibro.Text = "Seleccionar Libro";
            this.btnSelecLibro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecLibro.UseVisualStyleBackColor = false;
            this.btnSelecLibro.Click += new System.EventHandler(this.btnSelecLibro_Click);
            // 
            // txtLibro
            // 
            this.txtLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibro.Location = new System.Drawing.Point(76, 101);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(211, 26);
            this.txtLibro.TabIndex = 288;
            // 
            // txtElector
            // 
            this.txtElector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElector.Location = new System.Drawing.Point(77, 258);
            this.txtElector.Name = "txtElector";
            this.txtElector.Size = new System.Drawing.Size(211, 26);
            this.txtElector.TabIndex = 289;
            // 
            // txtBuscarLibro
            // 
            this.txtBuscarLibro.Location = new System.Drawing.Point(430, 50);
            this.txtBuscarLibro.Name = "txtBuscarLibro";
            this.txtBuscarLibro.Size = new System.Drawing.Size(396, 20);
            this.txtBuscarLibro.TabIndex = 291;
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnBuscarLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnBuscarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarLibro.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarLibro.Image")));
            this.btnBuscarLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarLibro.Location = new System.Drawing.Point(826, 50);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(34, 20);
            this.btnBuscarLibro.TabIndex = 292;
            this.btnBuscarLibro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarLibro.UseVisualStyleBackColor = false;
            // 
            // btnBuscarElector
            // 
            this.btnBuscarElector.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarElector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarElector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarElector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnBuscarElector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnBuscarElector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarElector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarElector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarElector.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarElector.Image")));
            this.btnBuscarElector.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarElector.Location = new System.Drawing.Point(826, 297);
            this.btnBuscarElector.Name = "btnBuscarElector";
            this.btnBuscarElector.Size = new System.Drawing.Size(34, 20);
            this.btnBuscarElector.TabIndex = 294;
            this.btnBuscarElector.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarElector.UseVisualStyleBackColor = false;
            // 
            // txtBuscarElector
            // 
            this.txtBuscarElector.Location = new System.Drawing.Point(430, 297);
            this.txtBuscarElector.Name = "txtBuscarElector";
            this.txtBuscarElector.Size = new System.Drawing.Size(396, 20);
            this.txtBuscarElector.TabIndex = 293;
            // 
            // FormPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(878, 564);
            this.Controls.Add(this.btnBuscarElector);
            this.Controls.Add(this.txtBuscarElector);
            this.Controls.Add(this.btnBuscarLibro);
            this.Controls.Add(this.txtBuscarLibro);
            this.Controls.Add(this.txtElector);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.btnSelecLibro);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSelecElector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeSalida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbEdicion);
            this.Controls.Add(this.dataGridLectores);
            this.Controls.Add(this.dataGridLibros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.lblNumeroPrestamo);
            this.Controls.Add(this.LblIDLivro);
            this.Controls.Add(this.LblItemID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Elector);
            this.Controls.Add(this.LblEntrega);
            this.Controls.Add(this.txtCodigoLibro);
            this.Controls.Add(this.txtCodigoElector);
            this.Controls.Add(this.dateTimeEntrega);
            this.Name = "FormPrestamo";
            this.Text = "FormPrestamo";
            this.Load += new System.EventHandler(this.FormPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESTIMOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLectores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource eMPRESTIMOBindingSource;
        private System.Windows.Forms.Label lblNumeroPrestamo;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label LblIDLivro;
        private System.Windows.Forms.Label Elector;
        private System.Windows.Forms.Label LblEntrega;
        private System.Windows.Forms.DateTimePicker dateTimeEntrega;
        private System.Windows.Forms.TextBox txtCodigoElector;
        private System.Windows.Forms.Label LblItemID;
        private System.Windows.Forms.DataGridView dataGridLibros;
        private System.Windows.Forms.DataGridView dataGridLectores;
        private System.Windows.Forms.TextBox txtCodigoLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbEdicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeSalida;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSelecElector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSelecLibro;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.TextBox txtElector;
        private System.Windows.Forms.TextBox txtBuscarLibro;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.Button btnBuscarElector;
        private System.Windows.Forms.TextBox txtBuscarElector;
    }
}