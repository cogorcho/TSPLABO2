namespace Consultorio2013
{
    partial class Form1
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
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.lnkArchivos = new System.Windows.Forms.LinkLabel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cbxTipoDoc = new System.Windows.Forms.ComboBox();
            this.dtpFNac = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbMas = new System.Windows.Forms.RadioButton();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblFNac = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lvDatos = new System.Windows.Forms.ListView();
            this.chApellido = new System.Windows.Forms.ColumnHeader();
            this.chNombre = new System.Windows.Forms.ColumnHeader();
            this.chFechaNac = new System.Windows.Forms.ColumnHeader();
            this.chTipoDoc = new System.Windows.Forms.ColumnHeader();
            this.chDocumento = new System.Windows.Forms.ColumnHeader();
            this.chSexo = new System.Windows.Forms.ColumnHeader();
            this.chTelefono = new System.Windows.Forms.ColumnHeader();
            this.chEmail = new System.Windows.Forms.ColumnHeader();
            this.btnHC = new System.Windows.Forms.Button();
            this.rtnReporte = new System.Windows.Forms.Button();
            this.btnImagenes = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.gbxDatos.SuspendLayout();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.lnkArchivos);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.btnBorrar);
            this.gbxDatos.Controls.Add(this.btnNuevo);
            this.gbxDatos.Controls.Add(this.cbxTipoDoc);
            this.gbxDatos.Controls.Add(this.dtpFNac);
            this.gbxDatos.Controls.Add(this.txtEmail);
            this.gbxDatos.Controls.Add(this.txtTelefono);
            this.gbxDatos.Controls.Add(this.txtDocumento);
            this.gbxDatos.Controls.Add(this.txtNombre);
            this.gbxDatos.Controls.Add(this.txtApellido);
            this.gbxDatos.Controls.Add(this.gbxSexo);
            this.gbxDatos.Controls.Add(this.lblEmail);
            this.gbxDatos.Controls.Add(this.lblTelefono);
            this.gbxDatos.Controls.Add(this.lblDocumento);
            this.gbxDatos.Controls.Add(this.lblTipoDoc);
            this.gbxDatos.Controls.Add(this.lblFNac);
            this.gbxDatos.Controls.Add(this.lblNombre);
            this.gbxDatos.Controls.Add(this.lblApellido);
            this.gbxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.Location = new System.Drawing.Point(13, 13);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(402, 522);
            this.gbxDatos.TabIndex = 0;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos del Paciente";
            // 
            // lnkArchivos
            // 
            this.lnkArchivos.AutoSize = true;
            this.lnkArchivos.Location = new System.Drawing.Point(126, 468);
            this.lnkArchivos.Name = "lnkArchivos";
            this.lnkArchivos.Size = new System.Drawing.Size(166, 18);
            this.lnkArchivos.TabIndex = 12;
            this.lnkArchivos.TabStop = true;
            this.lnkArchivos.Text = "Archivos del Sistema";
            this.lnkArchivos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkArchivos_LinkClicked);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(284, 378);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 32);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
            // 
            // btnBorrar
            // 
            this.btnBorrar.ForeColor = System.Drawing.Color.Red;
            this.btnBorrar.Location = new System.Drawing.Point(153, 378);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 32);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar!";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(27, 378);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 32);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
            // 
            // cbxTipoDoc
            // 
            this.cbxTipoDoc.FormattingEnabled = true;
            this.cbxTipoDoc.Items.AddRange(new object[] {
            "DNI",
            "Cédula",
            "Pasaporte"});
            this.cbxTipoDoc.Location = new System.Drawing.Point(162, 143);
            this.cbxTipoDoc.Name = "cbxTipoDoc";
            this.cbxTipoDoc.Size = new System.Drawing.Size(221, 26);
            this.cbxTipoDoc.TabIndex = 4;
            // 
            // dtpFNac
            // 
            this.dtpFNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFNac.Location = new System.Drawing.Point(162, 112);
            this.dtpFNac.Name = "dtpFNac";
            this.dtpFNac.Size = new System.Drawing.Size(221, 24);
            this.dtpFNac.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(162, 327);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(221, 24);
            this.txtEmail.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(162, 286);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(221, 24);
            this.txtTelefono.TabIndex = 7;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(162, 179);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(221, 24);
            this.txtDocumento.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(162, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(221, 24);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(162, 46);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(221, 24);
            this.txtApellido.TabIndex = 1;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbMas);
            this.gbxSexo.Controls.Add(this.rbFem);
            this.gbxSexo.Location = new System.Drawing.Point(26, 218);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(357, 53);
            this.gbxSexo.TabIndex = 6;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbMas
            // 
            this.rbMas.Location = new System.Drawing.Point(207, 23);
            this.rbMas.Name = "rbMas";
            this.rbMas.Size = new System.Drawing.Size(109, 24);
            this.rbMas.TabIndex = 1;
            this.rbMas.Text = "Masculino";
            this.rbMas.UseVisualStyleBackColor = true;
            // 
            // rbFem
            // 
            this.rbFem.Checked = true;
            this.rbFem.Location = new System.Drawing.Point(23, 23);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(101, 24);
            this.rbFem.TabIndex = 0;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Femenino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(26, 327);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "EMail";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(26, 283);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(100, 23);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDocumento
            // 
            this.lblDocumento.Location = new System.Drawing.Point(26, 179);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(100, 23);
            this.lblDocumento.TabIndex = 4;
            this.lblDocumento.Text = "Documento";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.Location = new System.Drawing.Point(26, 142);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(100, 23);
            this.lblTipoDoc.TabIndex = 3;
            this.lblTipoDoc.Text = "Tipo Doc";
            // 
            // lblFNac
            // 
            this.lblFNac.Location = new System.Drawing.Point(26, 110);
            this.lblFNac.Name = "lblFNac";
            this.lblFNac.Size = new System.Drawing.Size(100, 23);
            this.lblFNac.TabIndex = 2;
            this.lblFNac.Text = "Fecha Nac";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(26, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 23);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(26, 46);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(100, 23);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1008, 491);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 44);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
            // 
            // lvDatos
            // 
            this.lvDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chApellido,
            this.chNombre,
            this.chFechaNac,
            this.chTipoDoc,
            this.chDocumento,
            this.chSexo,
            this.chTelefono,
            this.chEmail});
            this.lvDatos.FullRowSelect = true;
            this.lvDatos.GridLines = true;
            this.lvDatos.Location = new System.Drawing.Point(438, 23);
            this.lvDatos.Name = "lvDatos";
            this.lvDatos.Size = new System.Drawing.Size(681, 453);
            this.lvDatos.TabIndex = 13;
            this.lvDatos.UseCompatibleStateImageBehavior = false;
            this.lvDatos.View = System.Windows.Forms.View.Details;
            this.lvDatos.DoubleClick += new System.EventHandler(this.lvDatos_DoubleClick);
            // 
            // chApellido
            // 
            this.chApellido.Text = "Apellido";
            this.chApellido.Width = 100;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 86;
            // 
            // chFechaNac
            // 
            this.chFechaNac.Text = "Fech Nac";
            this.chFechaNac.Width = 71;
            // 
            // chTipoDoc
            // 
            this.chTipoDoc.Text = "Tipo Doc";
            this.chTipoDoc.Width = 65;
            // 
            // chDocumento
            // 
            this.chDocumento.Text = "Documento";
            this.chDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chDocumento.Width = 101;
            // 
            // chSexo
            // 
            this.chSexo.Text = "Sexo";
            this.chSexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chTelefono
            // 
            this.chTelefono.Text = "Telefono";
            this.chTelefono.Width = 66;
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            this.chEmail.Width = 110;
            // 
            // btnHC
            // 
            this.btnHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHC.Location = new System.Drawing.Point(438, 492);
            this.btnHC.Name = "btnHC";
            this.btnHC.Size = new System.Drawing.Size(75, 43);
            this.btnHC.TabIndex = 14;
            this.btnHC.Text = "HC";
            this.btnHC.UseVisualStyleBackColor = true;
            this.btnHC.Click += new System.EventHandler(this.btnHC_Click);
            // 
            // rtnReporte
            // 
            this.rtnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtnReporte.Location = new System.Drawing.Point(530, 492);
            this.rtnReporte.Name = "rtnReporte";
            this.rtnReporte.Size = new System.Drawing.Size(80, 43);
            this.rtnReporte.TabIndex = 15;
            this.rtnReporte.Text = "Reporte";
            this.rtnReporte.UseVisualStyleBackColor = true;
            this.rtnReporte.Click += new System.EventHandler(this.rtnReporte_Click);
            // 
            // btnImagenes
            // 
            this.btnImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagenes.Location = new System.Drawing.Point(626, 492);
            this.btnImagenes.Name = "btnImagenes";
            this.btnImagenes.Size = new System.Drawing.Size(86, 43);
            this.btnImagenes.TabIndex = 16;
            this.btnImagenes.Text = "Imagenes";
            this.btnImagenes.UseVisualStyleBackColor = true;
            this.btnImagenes.Click += new System.EventHandler(this.btnImagenes_Click_1);
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(729, 491);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(86, 43);
            this.btnBackup.TabIndex = 17;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 558);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnImagenes);
            this.Controls.Add(this.rtnReporte);
            this.Controls.Add(this.btnHC);
            this.Controls.Add(this.lvDatos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbxDatos);
            this.Name = "Form1";
            this.Text = "Consultorio";
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.gbxSexo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.ColumnHeader chEmail;
		private System.Windows.Forms.ColumnHeader chTelefono;
		private System.Windows.Forms.ColumnHeader chSexo;
		private System.Windows.Forms.ColumnHeader chDocumento;
		private System.Windows.Forms.ColumnHeader chTipoDoc;
		private System.Windows.Forms.ColumnHeader chFechaNac;
		private System.Windows.Forms.ColumnHeader chNombre;
		private System.Windows.Forms.ColumnHeader chApellido;
		private System.Windows.Forms.ListView lvDatos;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label lblApellido;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblFNac;
		private System.Windows.Forms.Label lblTipoDoc;
		private System.Windows.Forms.Label lblDocumento;
		private System.Windows.Forms.Label lblTelefono;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.RadioButton rbFem;
		private System.Windows.Forms.RadioButton rbMas;
		private System.Windows.Forms.GroupBox gbxSexo;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtDocumento;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.DateTimePicker dtpFNac;
		private System.Windows.Forms.ComboBox cbxTipoDoc;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.LinkLabel lnkArchivos;
        private System.Windows.Forms.Button btnHC;
        private System.Windows.Forms.Button rtnReporte;
        private System.Windows.Forms.Button btnImagenes;
        private System.Windows.Forms.Button btnBackup;
	}
}

