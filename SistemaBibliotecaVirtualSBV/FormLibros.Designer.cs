
namespace SistemaBibliotecaVirtualSBV
{
    partial class FormLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLibro));
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdicion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.txtIdLibro = new System.Windows.Forms.TextBox();
            this.txtFechaEdicion = new System.Windows.Forms.DateTimePicker();
            this.txtCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.txtNumPagina = new System.Windows.Forms.TextBox();
            this.txtCodigoEditorial = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEjemplares = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Location = new System.Drawing.Point(618, 384);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(95, 27);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar ";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(379, 124);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(455, 245);
            this.dataGridView1.TabIndex = 260;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEdicion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.txtFechaPublicacion);
            this.groupBox1.Controls.Add(this.txtIdLibro);
            this.groupBox1.Controls.Add(this.txtFechaEdicion);
            this.groupBox1.Controls.Add(this.txtCategoria);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNombreLibro);
            this.groupBox1.Controls.Add(this.txtNumPagina);
            this.groupBox1.Controls.Add(this.txtCodigoEditorial);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtIdioma);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtEjemplares);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(11, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 320);
            this.groupBox1.TabIndex = 267;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 211;
            this.label2.Text = "Codigo de libro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 212;
            this.label3.Text = "Nombre de libro:";
            // 
            // txtEdicion
            // 
            this.txtEdicion.FormattingEnabled = true;
            this.txtEdicion.Items.AddRange(new object[] {
            "1°ra",
            "2°da",
            "3°ra",
            "4°ta",
            "5°ta",
            "6°ta",
            "7°ma",
            "8°va",
            "9°ma",
            "10°ma"});
            this.txtEdicion.Location = new System.Drawing.Point(181, 229);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(165, 21);
            this.txtEdicion.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 213;
            this.label4.Text = "Autor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 214;
            this.label5.Text = "Codigo editorial:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(94, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 216;
            this.label7.Text = "Categoria:";
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.Color.White;
            this.txtAutor.Location = new System.Drawing.Point(181, 68);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(165, 20);
            this.txtAutor.TabIndex = 3;
            // 
            // txtFechaPublicacion
            // 
            this.txtFechaPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaPublicacion.Location = new System.Drawing.Point(181, 205);
            this.txtFechaPublicacion.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.txtFechaPublicacion.Name = "txtFechaPublicacion";
            this.txtFechaPublicacion.Size = new System.Drawing.Size(165, 20);
            this.txtFechaPublicacion.TabIndex = 8;
            // 
            // txtIdLibro
            // 
            this.txtIdLibro.BackColor = System.Drawing.Color.White;
            this.txtIdLibro.Location = new System.Drawing.Point(181, 14);
            this.txtIdLibro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIdLibro.Name = "txtIdLibro";
            this.txtIdLibro.Size = new System.Drawing.Size(165, 20);
            this.txtIdLibro.TabIndex = 1;
            // 
            // txtFechaEdicion
            // 
            this.txtFechaEdicion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaEdicion.Location = new System.Drawing.Point(181, 179);
            this.txtFechaEdicion.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.txtFechaEdicion.MinDate = new System.DateTime(1759, 1, 1, 0, 0, 0, 0);
            this.txtFechaEdicion.Name = "txtFechaEdicion";
            this.txtFechaEdicion.Size = new System.Drawing.Size(165, 20);
            this.txtFechaEdicion.TabIndex = 7;
            // 
            // txtCategoria
            // 
            this.txtCategoria.FormattingEnabled = true;
            this.txtCategoria.Items.AddRange(new object[] {
            "ARTE",
            "AVENTURAS",
            "AUTOAYUDA",
            "ARQUITECTURA",
            "ADMINISTRACIÓN",
            "BIOGRAFÍA",
            "BÉLICO",
            "BIOLOGÍA",
            "CLÁSICA",
            "CLÁSICO",
            "CRÍTICA Y TEORÍA LITERARIA",
            "CUENTOS",
            "CIENCIA FICCIÓN",
            "CIENCIA",
            "CIENCIAS EXACTAS",
            "CIENCIAS NATURALES",
            "CIENCIAS SOCIALES",
            "CONTABILIDAD",
            "COMUNICACIÓN",
            "COMICS",
            "CIENCIAS OCULTAS",
            "DEPORTES Y JUEGOS",
            "DEPORTES",
            "DICCIONARIOS Y ENCICLOPEDIAS",
            "DIVULGACIÓN",
            "DIVULGACIÓN CIENTÍFICA",
            "DIDÁCTICO",
            "DRAMA",
            "ENSAYO",
            "ERÓTICO",
            "ESOTERISMO",
            "ESPIRITUALIDAD",
            "ECONOMÍA",
            "EMPLEO Y EMPRESAS",
            "FINANZAS",
            "FANTÁSTICO",
            "FILOSOFÍA",
            "FILOSÓFICO",
            "FÍSICA",
            "HISTORIA",
            "HISTÓRICO",
            "HOGAR",
            "HUMOR",
            "INFANTIL",
            " JUVENIL",
            "INTRIGA",
            "IDIOMAS",
            "INTERACTIVO",
            "INGENIERÍA",
            "JUVENIL",
            "MANUALIDADES",
            "MISTERIO",
            "MEMORIAS",
            "MEDICINA",
            "MATEMÁTICA",
            "MANUALES DE SOFTWARE",
            "MANUALES Y CURSOS",
            "MECÁNICA",
            "NARRATIVA",
            "NARRATIVA DE HUMOR",
            "NOVELA",
            "NOVELA NEGRA",
            "NARRATIVA ERÓTICA",
            "NARRATIVA HISTÓRICA",
            "PADRES E HIJOS",
            "POLICIAL",
            "POLICIACO",
            "POESÍA",
            "PSICOLOGÍA",
            "PSICOLÓGICO",
            "PEDAGOGÍA",
            "POLÍTICA Y SOCIEDAD",
            "POLÍTICA",
            "PROGRAMACIÓN",
            "QUÍMICA",
            "REALISTA",
            "RELATO",
            "ROMANCE",
            "ROMANTICO",
            "ARROWLIBROS R-V",
            "REFERENCIA",
            "RELIGIÓN",
            "SÁTIRA",
            "SUSPENSO",
            "SEXUALIDAD",
            "SALUD Y BIENESTAR",
            "SOLUCIONARIOS",
            "TEATRO",
            "TERROR",
            "TECNOLOGÍA",
            "VIAJES",
            "VETERINARIA",
            "VARIOS GÉNEROS",
            "VARIADA"});
            this.txtCategoria.Location = new System.Drawing.Point(181, 95);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(165, 21);
            this.txtCategoria.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 215;
            this.label6.Text = "N°pagina:";
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.BackColor = System.Drawing.Color.White;
            this.txtNombreLibro.Location = new System.Drawing.Point(181, 40);
            this.txtNombreLibro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(165, 20);
            this.txtNombreLibro.TabIndex = 2;
            // 
            // txtNumPagina
            // 
            this.txtNumPagina.BackColor = System.Drawing.Color.White;
            this.txtNumPagina.Location = new System.Drawing.Point(181, 122);
            this.txtNumPagina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumPagina.Name = "txtNumPagina";
            this.txtNumPagina.Size = new System.Drawing.Size(165, 20);
            this.txtNumPagina.TabIndex = 5;
            // 
            // txtCodigoEditorial
            // 
            this.txtCodigoEditorial.Location = new System.Drawing.Point(181, 151);
            this.txtCodigoEditorial.Name = "txtCodigoEditorial";
            this.txtCodigoEditorial.Size = new System.Drawing.Size(165, 20);
            this.txtCodigoEditorial.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(59, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 18);
            this.label12.TabIndex = 225;
            this.label12.Text = "N°ejemplares:";
            // 
            // txtIdioma
            // 
            this.txtIdioma.BackColor = System.Drawing.Color.White;
            this.txtIdioma.Location = new System.Drawing.Point(181, 255);
            this.txtIdioma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(165, 20);
            this.txtIdioma.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(111, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 18);
            this.label11.TabIndex = 224;
            this.label11.Text = "Idioma:";
            // 
            // txtEjemplares
            // 
            this.txtEjemplares.BackColor = System.Drawing.Color.White;
            this.txtEjemplares.Location = new System.Drawing.Point(181, 281);
            this.txtEjemplares.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEjemplares.Name = "txtEjemplares";
            this.txtEjemplares.Size = new System.Drawing.Size(165, 20);
            this.txtEjemplares.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(106, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 223;
            this.label10.Text = "Edicion:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 18);
            this.label8.TabIndex = 221;
            this.label8.Text = "Fecha de edicion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 18);
            this.label9.TabIndex = 222;
            this.label9.Text = "Fecha de publicacion:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(648, 98);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(36, 20);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(380, 384);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 27);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(739, 384);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(95, 27);
            this.btnSeleccionar.TabIndex = 16;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(499, 384);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 27);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(11, 27);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(77, 27);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(307, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(230, 63);
            this.label16.TabIndex = 269;
            this.label16.Text = "LIBROS";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(379, 98);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(271, 20);
            this.txtBuscar.TabIndex = 17;
            // 
            // FormLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 431);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtBuscar);
            this.MaximumSize = new System.Drawing.Size(860, 470);
            this.MinimumSize = new System.Drawing.Size(860, 470);
            this.Name = "FormLibro";
            this.Text = "FORMULARIO LIBROS";
            this.Load += new System.EventHandler(this.FormLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtEdicion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.DateTimePicker txtFechaPublicacion;
        private System.Windows.Forms.TextBox txtIdLibro;
        private System.Windows.Forms.DateTimePicker txtFechaEdicion;
        private System.Windows.Forms.ComboBox txtCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.TextBox txtNumPagina;
        private System.Windows.Forms.TextBox txtCodigoEditorial;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEjemplares;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}

