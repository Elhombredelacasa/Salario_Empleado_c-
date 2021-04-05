namespace Salario_Empleados
{
    partial class General
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.tituloSuperior = new System.Windows.Forms.Label();
            this.barraInferior = new System.Windows.Forms.Panel();
            this.empleado = new System.Windows.Forms.Label();
            this.infoSueldoBase = new System.Windows.Forms.Label();
            this.impSaldoBase = new System.Windows.Forms.Label();
            this.infoValorcomisiones = new System.Windows.Forms.Label();
            this.impcomisiones = new System.Windows.Forms.Label();
            this.InfoValorBeneficios = new System.Windows.Forms.Label();
            this.impValorbeneficios = new System.Windows.Forms.Label();
            this.infoSubsidiodetransporte = new System.Windows.Forms.Label();
            this.impSubsidiodetransporte = new System.Windows.Forms.Label();
            this.infoHorasExtras = new System.Windows.Forms.Label();
            this.impHorasExtras = new System.Windows.Forms.Label();
            this.infoSeguridadsocial = new System.Windows.Forms.Label();
            this.impSeguridadsocial = new System.Windows.Forms.Label();
            this.infoValortotaldevengado = new System.Windows.Forms.Label();
            this.impValortotaldevengado = new System.Windows.Forms.Label();
            this.pnRegistros = new System.Windows.Forms.Panel();
            this.btncerrarRegistros = new System.Windows.Forms.Button();
            this.listaRegistros = new System.Windows.Forms.ListView();
            this.listviewnombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewcedula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewgenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewfecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewcargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.barraMedia = new System.Windows.Forms.Panel();
            this.grupoInfoPersonal = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lineaNombre = new System.Windows.Forms.Panel();
            this.txtIdentidficacion = new System.Windows.Forms.TextBox();
            this.lineaIdentificacion = new System.Windows.Forms.Panel();
            this.labelGenero = new System.Windows.Forms.Label();
            this.radioMasculino = new System.Windows.Forms.RadioButton();
            this.radioFemenino = new System.Windows.Forms.RadioButton();
            this.grupoEfectividad = new System.Windows.Forms.GroupBox();
            this.titulohorastrabajadas = new System.Windows.Forms.Label();
            this.horastrabajadasporsemana = new System.Windows.Forms.Label();
            this.medidonumerohoras = new System.Windows.Forms.TrackBar();
            this.txtventastotal = new System.Windows.Forms.TextBox();
            this.lineaValor = new System.Windows.Forms.Panel();
            this.grupoInfoempresarial = new System.Windows.Forms.GroupBox();
            this.tituloFechaingreso = new System.Windows.Forms.Label();
            this.fechaingresoempleado = new System.Windows.Forms.DateTimePicker();
            this.tituloCargoEmpleado = new System.Windows.Forms.Label();
            this.listcomboboxcargosempleados = new System.Windows.Forms.ComboBox();
            this.msnError = new System.Windows.Forms.Label();
            this.toolclick = new System.Windows.Forms.ToolTip(this.components);
            this.btninfo = new System.Windows.Forms.Button();
            this.imgDinero = new System.Windows.Forms.PictureBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.imgcargo = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegistros = new System.Windows.Forms.Button();
            this.barraSuperior.SuspendLayout();
            this.barraInferior.SuspendLayout();
            this.pnRegistros.SuspendLayout();
            this.barraMedia.SuspendLayout();
            this.grupoInfoPersonal.SuspendLayout();
            this.grupoEfectividad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medidonumerohoras)).BeginInit();
            this.grupoInfoempresarial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDinero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcargo)).BeginInit();
            this.SuspendLayout();
            // 
            // barraSuperior
            // 
            this.barraSuperior.BackColor = System.Drawing.SystemColors.Highlight;
            this.barraSuperior.Controls.Add(this.btninfo);
            this.barraSuperior.Controls.Add(this.tituloSuperior);
            this.barraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(625, 54);
            this.barraSuperior.TabIndex = 0;
            this.barraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraSuperior_MouseDown);
            // 
            // tituloSuperior
            // 
            this.tituloSuperior.AutoSize = true;
            this.tituloSuperior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tituloSuperior.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloSuperior.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tituloSuperior.Location = new System.Drawing.Point(220, 14);
            this.tituloSuperior.Name = "tituloSuperior";
            this.tituloSuperior.Size = new System.Drawing.Size(252, 18);
            this.tituloSuperior.TabIndex = 0;
            this.tituloSuperior.Text = "Sistema de calculo de salarios";
            // 
            // barraInferior
            // 
            this.barraInferior.BackColor = System.Drawing.SystemColors.Highlight;
            this.barraInferior.Controls.Add(this.empleado);
            this.barraInferior.Controls.Add(this.imgcargo);
            this.barraInferior.Controls.Add(this.infoSueldoBase);
            this.barraInferior.Controls.Add(this.impSaldoBase);
            this.barraInferior.Controls.Add(this.infoValorcomisiones);
            this.barraInferior.Controls.Add(this.impcomisiones);
            this.barraInferior.Controls.Add(this.InfoValorBeneficios);
            this.barraInferior.Controls.Add(this.impValorbeneficios);
            this.barraInferior.Controls.Add(this.infoSubsidiodetransporte);
            this.barraInferior.Controls.Add(this.impSubsidiodetransporte);
            this.barraInferior.Controls.Add(this.infoHorasExtras);
            this.barraInferior.Controls.Add(this.impHorasExtras);
            this.barraInferior.Controls.Add(this.infoSeguridadsocial);
            this.barraInferior.Controls.Add(this.impSeguridadsocial);
            this.barraInferior.Controls.Add(this.infoValortotaldevengado);
            this.barraInferior.Controls.Add(this.impValortotaldevengado);
            this.barraInferior.Controls.Add(this.btnGuardar);
            this.barraInferior.Controls.Add(this.btnRegistros);
            this.barraInferior.Controls.Add(this.pnRegistros);
            this.barraInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraInferior.Location = new System.Drawing.Point(0, 243);
            this.barraInferior.Name = "barraInferior";
            this.barraInferior.Size = new System.Drawing.Size(625, 207);
            this.barraInferior.TabIndex = 1;
            this.barraInferior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraInferior_MouseDown);
            // 
            // empleado
            // 
            this.empleado.AutoSize = true;
            this.empleado.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.empleado.Location = new System.Drawing.Point(91, 171);
            this.empleado.Name = "empleado";
            this.empleado.Size = new System.Drawing.Size(0, 13);
            this.empleado.TabIndex = 12;
            // 
            // infoSueldoBase
            // 
            this.infoSueldoBase.AutoSize = true;
            this.infoSueldoBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoSueldoBase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoSueldoBase.Location = new System.Drawing.Point(259, 18);
            this.infoSueldoBase.Name = "infoSueldoBase";
            this.infoSueldoBase.Size = new System.Drawing.Size(229, 20);
            this.infoSueldoBase.TabIndex = 1;
            this.infoSueldoBase.Text = "Sueldo base :                    $";
            // 
            // impSaldoBase
            // 
            this.impSaldoBase.AutoSize = true;
            this.impSaldoBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impSaldoBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.impSaldoBase.Location = new System.Drawing.Point(484, 18);
            this.impSaldoBase.Name = "impSaldoBase";
            this.impSaldoBase.Size = new System.Drawing.Size(18, 20);
            this.impSaldoBase.TabIndex = 9;
            this.impSaldoBase.Text = "0";
            // 
            // infoValorcomisiones
            // 
            this.infoValorcomisiones.AutoSize = true;
            this.infoValorcomisiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoValorcomisiones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoValorcomisiones.Location = new System.Drawing.Point(259, 38);
            this.infoValorcomisiones.Name = "infoValorcomisiones";
            this.infoValorcomisiones.Size = new System.Drawing.Size(230, 20);
            this.infoValorcomisiones.TabIndex = 2;
            this.infoValorcomisiones.Text = "Valor de comisiones :        $";
            // 
            // impcomisiones
            // 
            this.impcomisiones.AutoSize = true;
            this.impcomisiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impcomisiones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.impcomisiones.Location = new System.Drawing.Point(484, 38);
            this.impcomisiones.Name = "impcomisiones";
            this.impcomisiones.Size = new System.Drawing.Size(18, 20);
            this.impcomisiones.TabIndex = 9;
            this.impcomisiones.Text = "0";
            // 
            // InfoValorBeneficios
            // 
            this.InfoValorBeneficios.AutoSize = true;
            this.InfoValorBeneficios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoValorBeneficios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InfoValorBeneficios.Location = new System.Drawing.Point(261, 58);
            this.InfoValorBeneficios.Name = "InfoValorBeneficios";
            this.InfoValorBeneficios.Size = new System.Drawing.Size(228, 20);
            this.InfoValorBeneficios.TabIndex = 3;
            this.InfoValorBeneficios.Text = "Valor beneficios :              $";
            // 
            // impValorbeneficios
            // 
            this.impValorbeneficios.AutoSize = true;
            this.impValorbeneficios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impValorbeneficios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.impValorbeneficios.Location = new System.Drawing.Point(484, 58);
            this.impValorbeneficios.Name = "impValorbeneficios";
            this.impValorbeneficios.Size = new System.Drawing.Size(18, 20);
            this.impValorbeneficios.TabIndex = 9;
            this.impValorbeneficios.Text = "0";
            // 
            // infoSubsidiodetransporte
            // 
            this.infoSubsidiodetransporte.AutoSize = true;
            this.infoSubsidiodetransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoSubsidiodetransporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoSubsidiodetransporte.Location = new System.Drawing.Point(259, 78);
            this.infoSubsidiodetransporte.Name = "infoSubsidiodetransporte";
            this.infoSubsidiodetransporte.Size = new System.Drawing.Size(230, 20);
            this.infoSubsidiodetransporte.TabIndex = 4;
            this.infoSubsidiodetransporte.Text = "Valor subsidio transporte :$";
            // 
            // impSubsidiodetransporte
            // 
            this.impSubsidiodetransporte.AutoSize = true;
            this.impSubsidiodetransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impSubsidiodetransporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.impSubsidiodetransporte.Location = new System.Drawing.Point(484, 78);
            this.impSubsidiodetransporte.Name = "impSubsidiodetransporte";
            this.impSubsidiodetransporte.Size = new System.Drawing.Size(18, 20);
            this.impSubsidiodetransporte.TabIndex = 9;
            this.impSubsidiodetransporte.Text = "0";
            // 
            // infoHorasExtras
            // 
            this.infoHorasExtras.AutoSize = true;
            this.infoHorasExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoHorasExtras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoHorasExtras.Location = new System.Drawing.Point(258, 98);
            this.infoHorasExtras.Name = "infoHorasExtras";
            this.infoHorasExtras.Size = new System.Drawing.Size(230, 20);
            this.infoHorasExtras.TabIndex = 7;
            this.infoHorasExtras.Text = "Valor horas extras :           $";
            // 
            // impHorasExtras
            // 
            this.impHorasExtras.AutoSize = true;
            this.impHorasExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impHorasExtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.impHorasExtras.Location = new System.Drawing.Point(484, 98);
            this.impHorasExtras.Name = "impHorasExtras";
            this.impHorasExtras.Size = new System.Drawing.Size(18, 20);
            this.impHorasExtras.TabIndex = 9;
            this.impHorasExtras.Text = "0";
            // 
            // infoSeguridadsocial
            // 
            this.infoSeguridadsocial.AutoSize = true;
            this.infoSeguridadsocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoSeguridadsocial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoSeguridadsocial.Location = new System.Drawing.Point(262, 118);
            this.infoSeguridadsocial.Name = "infoSeguridadsocial";
            this.infoSeguridadsocial.Size = new System.Drawing.Size(227, 20);
            this.infoSeguridadsocial.TabIndex = 6;
            this.infoSeguridadsocial.Text = "Seguridad social :             $";
            // 
            // impSeguridadsocial
            // 
            this.impSeguridadsocial.AutoSize = true;
            this.impSeguridadsocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impSeguridadsocial.ForeColor = System.Drawing.Color.Red;
            this.impSeguridadsocial.Location = new System.Drawing.Point(484, 118);
            this.impSeguridadsocial.Name = "impSeguridadsocial";
            this.impSeguridadsocial.Size = new System.Drawing.Size(19, 20);
            this.impSeguridadsocial.TabIndex = 9;
            this.impSeguridadsocial.Text = "0";
            // 
            // infoValortotaldevengado
            // 
            this.infoValortotaldevengado.AutoSize = true;
            this.infoValortotaldevengado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoValortotaldevengado.ForeColor = System.Drawing.Color.Gold;
            this.infoValortotaldevengado.Location = new System.Drawing.Point(256, 152);
            this.infoValortotaldevengado.Name = "infoValortotaldevengado";
            this.infoValortotaldevengado.Size = new System.Drawing.Size(240, 20);
            this.infoValortotaldevengado.TabIndex = 5;
            this.infoValortotaldevengado.Text = "Valor total devengado :       $";
            // 
            // impValortotaldevengado
            // 
            this.impValortotaldevengado.AutoSize = true;
            this.impValortotaldevengado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impValortotaldevengado.ForeColor = System.Drawing.Color.White;
            this.impValortotaldevengado.Location = new System.Drawing.Point(498, 148);
            this.impValortotaldevengado.Name = "impValortotaldevengado";
            this.impValortotaldevengado.Size = new System.Drawing.Size(21, 24);
            this.impValortotaldevengado.TabIndex = 9;
            this.impValortotaldevengado.Text = "0";
            // 
            // pnRegistros
            // 
            this.pnRegistros.Controls.Add(this.btncerrarRegistros);
            this.pnRegistros.Controls.Add(this.listaRegistros);
            this.pnRegistros.Location = new System.Drawing.Point(0, 0);
            this.pnRegistros.Name = "pnRegistros";
            this.pnRegistros.Size = new System.Drawing.Size(625, 207);
            this.pnRegistros.TabIndex = 14;
            this.pnRegistros.Visible = false;
            this.pnRegistros.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnRegistros_MouseDown);
            // 
            // btncerrarRegistros
            // 
            this.btncerrarRegistros.FlatAppearance.BorderSize = 0;
            this.btncerrarRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrarRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrarRegistros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncerrarRegistros.Location = new System.Drawing.Point(602, 6);
            this.btncerrarRegistros.Name = "btncerrarRegistros";
            this.btncerrarRegistros.Size = new System.Drawing.Size(20, 20);
            this.btncerrarRegistros.TabIndex = 1;
            this.btncerrarRegistros.Text = "X";
            this.btncerrarRegistros.UseVisualStyleBackColor = true;
            this.btncerrarRegistros.Click += new System.EventHandler(this.btncerrarRegistros_Click);
            // 
            // listaRegistros
            // 
            this.listaRegistros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listviewnombre,
            this.listviewcedula,
            this.listviewgenero,
            this.listviewfecha,
            this.listviewcargo});
            this.listaRegistros.HideSelection = false;
            this.listaRegistros.Location = new System.Drawing.Point(32, 38);
            this.listaRegistros.Name = "listaRegistros";
            this.listaRegistros.Size = new System.Drawing.Size(569, 157);
            this.listaRegistros.TabIndex = 0;
            this.listaRegistros.UseCompatibleStateImageBehavior = false;
            this.listaRegistros.View = System.Windows.Forms.View.Details;
            // 
            // listviewnombre
            // 
            this.listviewnombre.Text = "Nombre del empleado";
            this.listviewnombre.Width = 140;
            // 
            // listviewcedula
            // 
            this.listviewcedula.Text = "Cédula";
            this.listviewcedula.Width = 70;
            // 
            // listviewgenero
            // 
            this.listviewgenero.Text = "Sexo";
            this.listviewgenero.Width = 72;
            // 
            // listviewfecha
            // 
            this.listviewfecha.Text = "Fecha de ingreso a la empresa";
            this.listviewfecha.Width = 155;
            // 
            // listviewcargo
            // 
            this.listviewcargo.Text = "Cargo del empleado";
            this.listviewcargo.Width = 105;
            // 
            // barraMedia
            // 
            this.barraMedia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.barraMedia.Controls.Add(this.grupoInfoPersonal);
            this.barraMedia.Controls.Add(this.grupoEfectividad);
            this.barraMedia.Controls.Add(this.grupoInfoempresarial);
            this.barraMedia.Controls.Add(this.btnNuevo);
            this.barraMedia.Controls.Add(this.btnCalcular);
            this.barraMedia.Controls.Add(this.msnError);
            this.barraMedia.Controls.Add(this.btnSalir);
            this.barraMedia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraMedia.Location = new System.Drawing.Point(0, 54);
            this.barraMedia.Name = "barraMedia";
            this.barraMedia.Size = new System.Drawing.Size(625, 189);
            this.barraMedia.TabIndex = 2;
            this.barraMedia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraMedia_MouseDown);
            // 
            // grupoInfoPersonal
            // 
            this.grupoInfoPersonal.Controls.Add(this.txtNombre);
            this.grupoInfoPersonal.Controls.Add(this.lineaNombre);
            this.grupoInfoPersonal.Controls.Add(this.txtIdentidficacion);
            this.grupoInfoPersonal.Controls.Add(this.lineaIdentificacion);
            this.grupoInfoPersonal.Controls.Add(this.labelGenero);
            this.grupoInfoPersonal.Controls.Add(this.radioMasculino);
            this.grupoInfoPersonal.Controls.Add(this.radioFemenino);
            this.grupoInfoPersonal.Location = new System.Drawing.Point(12, 17);
            this.grupoInfoPersonal.Name = "grupoInfoPersonal";
            this.grupoInfoPersonal.Size = new System.Drawing.Size(170, 130);
            this.grupoInfoPersonal.TabIndex = 8;
            this.grupoInfoPersonal.TabStop = false;
            this.grupoInfoPersonal.Text = "Información personal";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(20, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(130, 13);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // lineaNombre
            // 
            this.lineaNombre.BackColor = System.Drawing.SystemColors.Control;
            this.lineaNombre.Enabled = false;
            this.lineaNombre.Location = new System.Drawing.Point(19, 55);
            this.lineaNombre.Name = "lineaNombre";
            this.lineaNombre.Size = new System.Drawing.Size(130, 2);
            this.lineaNombre.TabIndex = 15;
            // 
            // txtIdentidficacion
            // 
            this.txtIdentidficacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentidficacion.Location = new System.Drawing.Point(19, 66);
            this.txtIdentidficacion.Name = "txtIdentidficacion";
            this.txtIdentidficacion.Size = new System.Drawing.Size(130, 13);
            this.txtIdentidficacion.TabIndex = 2;
            this.txtIdentidficacion.Enter += new System.EventHandler(this.txtIdentidficacion_Enter);
            this.txtIdentidficacion.Leave += new System.EventHandler(this.txtIdentidficacion_Leave);
            // 
            // lineaIdentificacion
            // 
            this.lineaIdentificacion.BackColor = System.Drawing.SystemColors.Control;
            this.lineaIdentificacion.Enabled = false;
            this.lineaIdentificacion.Location = new System.Drawing.Point(19, 82);
            this.lineaIdentificacion.Name = "lineaIdentificacion";
            this.lineaIdentificacion.Size = new System.Drawing.Size(130, 2);
            this.lineaIdentificacion.TabIndex = 16;
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Enabled = false;
            this.labelGenero.Location = new System.Drawing.Point(62, 86);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(42, 13);
            this.labelGenero.TabIndex = 4;
            this.labelGenero.Text = "Genero";
            // 
            // radioMasculino
            // 
            this.radioMasculino.AutoSize = true;
            this.radioMasculino.Location = new System.Drawing.Point(14, 107);
            this.radioMasculino.Name = "radioMasculino";
            this.radioMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioMasculino.TabIndex = 3;
            this.radioMasculino.TabStop = true;
            this.radioMasculino.Text = "Masculino";
            this.radioMasculino.UseVisualStyleBackColor = true;
            // 
            // radioFemenino
            // 
            this.radioFemenino.AutoSize = true;
            this.radioFemenino.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.radioFemenino.Location = new System.Drawing.Point(93, 107);
            this.radioFemenino.Name = "radioFemenino";
            this.radioFemenino.Size = new System.Drawing.Size(71, 17);
            this.radioFemenino.TabIndex = 4;
            this.radioFemenino.TabStop = true;
            this.radioFemenino.Text = "Femenino";
            this.radioFemenino.UseVisualStyleBackColor = true;
            // 
            // grupoEfectividad
            // 
            this.grupoEfectividad.Controls.Add(this.titulohorastrabajadas);
            this.grupoEfectividad.Controls.Add(this.horastrabajadasporsemana);
            this.grupoEfectividad.Controls.Add(this.medidonumerohoras);
            this.grupoEfectividad.Controls.Add(this.imgDinero);
            this.grupoEfectividad.Controls.Add(this.txtventastotal);
            this.grupoEfectividad.Controls.Add(this.lineaValor);
            this.grupoEfectividad.Location = new System.Drawing.Point(431, 17);
            this.grupoEfectividad.Name = "grupoEfectividad";
            this.grupoEfectividad.Size = new System.Drawing.Size(170, 130);
            this.grupoEfectividad.TabIndex = 10;
            this.grupoEfectividad.TabStop = false;
            this.grupoEfectividad.Text = "Efectividad y cumplimiento";
            // 
            // titulohorastrabajadas
            // 
            this.titulohorastrabajadas.AutoSize = true;
            this.titulohorastrabajadas.Location = new System.Drawing.Point(3, 18);
            this.titulohorastrabajadas.Name = "titulohorastrabajadas";
            this.titulohorastrabajadas.Size = new System.Drawing.Size(148, 13);
            this.titulohorastrabajadas.TabIndex = 8;
            this.titulohorastrabajadas.Text = "Horas trabajadas por semana:";
            // 
            // horastrabajadasporsemana
            // 
            this.horastrabajadasporsemana.AutoSize = true;
            this.horastrabajadasporsemana.Location = new System.Drawing.Point(151, 18);
            this.horastrabajadasporsemana.Name = "horastrabajadasporsemana";
            this.horastrabajadasporsemana.Size = new System.Drawing.Size(13, 13);
            this.horastrabajadasporsemana.TabIndex = 9;
            this.horastrabajadasporsemana.Text = "0";
            // 
            // medidonumerohoras
            // 
            this.medidonumerohoras.BackColor = System.Drawing.Color.White;
            this.medidonumerohoras.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.medidonumerohoras.LargeChange = 1;
            this.medidonumerohoras.Location = new System.Drawing.Point(6, 38);
            this.medidonumerohoras.Maximum = 60;
            this.medidonumerohoras.Minimum = 48;
            this.medidonumerohoras.Name = "medidonumerohoras";
            this.medidonumerohoras.Size = new System.Drawing.Size(158, 45);
            this.medidonumerohoras.SmallChange = 2;
            this.medidonumerohoras.TabIndex = 7;
            this.medidonumerohoras.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.medidonumerohoras.Value = 48;
            this.medidonumerohoras.Scroll += new System.EventHandler(this.medidonumerohoras_Scroll);
            // 
            // txtventastotal
            // 
            this.txtventastotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtventastotal.Location = new System.Drawing.Point(41, 89);
            this.txtventastotal.Name = "txtventastotal";
            this.txtventastotal.Size = new System.Drawing.Size(96, 13);
            this.txtventastotal.TabIndex = 15;
            this.txtventastotal.Enter += new System.EventHandler(this.txtventastotal_Enter);
            this.txtventastotal.Leave += new System.EventHandler(this.ventastotal_Leave);
            // 
            // lineaValor
            // 
            this.lineaValor.BackColor = System.Drawing.SystemColors.Control;
            this.lineaValor.Enabled = false;
            this.lineaValor.Location = new System.Drawing.Point(41, 108);
            this.lineaValor.Name = "lineaValor";
            this.lineaValor.Size = new System.Drawing.Size(100, 2);
            this.lineaValor.TabIndex = 17;
            // 
            // grupoInfoempresarial
            // 
            this.grupoInfoempresarial.Controls.Add(this.tituloFechaingreso);
            this.grupoInfoempresarial.Controls.Add(this.fechaingresoempleado);
            this.grupoInfoempresarial.Controls.Add(this.tituloCargoEmpleado);
            this.grupoInfoempresarial.Controls.Add(this.listcomboboxcargosempleados);
            this.grupoInfoempresarial.Location = new System.Drawing.Point(198, 17);
            this.grupoInfoempresarial.Name = "grupoInfoempresarial";
            this.grupoInfoempresarial.Size = new System.Drawing.Size(217, 130);
            this.grupoInfoempresarial.TabIndex = 9;
            this.grupoInfoempresarial.TabStop = false;
            this.grupoInfoempresarial.Text = "Información empresarial";
            // 
            // tituloFechaingreso
            // 
            this.tituloFechaingreso.AutoSize = true;
            this.tituloFechaingreso.Enabled = false;
            this.tituloFechaingreso.Location = new System.Drawing.Point(39, 18);
            this.tituloFechaingreso.Name = "tituloFechaingreso";
            this.tituloFechaingreso.Size = new System.Drawing.Size(152, 13);
            this.tituloFechaingreso.TabIndex = 10;
            this.tituloFechaingreso.Text = "Fecha de ingreso a la empresa";
            this.tituloFechaingreso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fechaingresoempleado
            // 
            this.fechaingresoempleado.Location = new System.Drawing.Point(11, 38);
            this.fechaingresoempleado.MaxDate = new System.DateTime(2020, 5, 14, 22, 58, 43, 0);
            this.fechaingresoempleado.Name = "fechaingresoempleado";
            this.fechaingresoempleado.Size = new System.Drawing.Size(193, 20);
            this.fechaingresoempleado.TabIndex = 5;
            this.fechaingresoempleado.Value = new System.DateTime(2020, 5, 14, 0, 0, 0, 0);
            // 
            // tituloCargoEmpleado
            // 
            this.tituloCargoEmpleado.AutoSize = true;
            this.tituloCargoEmpleado.Location = new System.Drawing.Point(62, 66);
            this.tituloCargoEmpleado.Name = "tituloCargoEmpleado";
            this.tituloCargoEmpleado.Size = new System.Drawing.Size(101, 13);
            this.tituloCargoEmpleado.TabIndex = 11;
            this.tituloCargoEmpleado.Text = "Cargo del empleado";
            // 
            // listcomboboxcargosempleados
            // 
            this.listcomboboxcargosempleados.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listcomboboxcargosempleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listcomboboxcargosempleados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listcomboboxcargosempleados.FormattingEnabled = true;
            this.listcomboboxcargosempleados.Location = new System.Drawing.Point(51, 87);
            this.listcomboboxcargosempleados.Name = "listcomboboxcargosempleados";
            this.listcomboboxcargosempleados.Size = new System.Drawing.Size(121, 21);
            this.listcomboboxcargosempleados.TabIndex = 6;
            this.listcomboboxcargosempleados.SelectedIndexChanged += new System.EventHandler(this.listcomboboxcargosempleados_SelectedIndexChanged);
            // 
            // msnError
            // 
            this.msnError.AutoSize = true;
            this.msnError.BackColor = System.Drawing.Color.Transparent;
            this.msnError.Enabled = false;
            this.msnError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msnError.ForeColor = System.Drawing.Color.DodgerBlue;
            this.msnError.Location = new System.Drawing.Point(28, 162);
            this.msnError.Name = "msnError";
            this.msnError.Size = new System.Drawing.Size(181, 13);
            this.msnError.TabIndex = 16;
            this.msnError.Text = "Corrije los campos señalados en rojo.";
            this.msnError.Visible = false;
            // 
            // toolclick
            // 
            this.toolclick.AutoPopDelay = 5000;
            this.toolclick.BackColor = System.Drawing.SystemColors.HighlightText;
            this.toolclick.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolclick.InitialDelay = 500;
            this.toolclick.IsBalloon = true;
            this.toolclick.ReshowDelay = 80;
            this.toolclick.ShowAlways = true;
            this.toolclick.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolclick.ToolTipTitle = "Click aquí";
            // 
            // btninfo
            // 
            this.btninfo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btninfo.BackgroundImage = global::Salario_Empleados.Properties.Resources.help;
            this.btninfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btninfo.FlatAppearance.BorderSize = 0;
            this.btninfo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btninfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninfo.Location = new System.Drawing.Point(592, 12);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(20, 20);
            this.btninfo.TabIndex = 1;
            this.toolclick.SetToolTip(this.btninfo, "para ver información del autor");
            this.btninfo.UseVisualStyleBackColor = false;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // imgDinero
            // 
            this.imgDinero.Image = global::Salario_Empleados.Properties.Resources.moneda;
            this.imgDinero.Location = new System.Drawing.Point(17, 84);
            this.imgDinero.Name = "imgDinero";
            this.imgDinero.Size = new System.Drawing.Size(24, 24);
            this.imgDinero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgDinero.TabIndex = 17;
            this.imgDinero.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevo.BackgroundImage = global::Salario_Empleados.Properties.Resources.nuevo;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevo.Location = new System.Drawing.Point(530, 158);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(25, 25);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolclick.SetToolTip(this.btnNuevo, "Para registrar un nuevo empleado");
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Image = global::Salario_Empleados.Properties.Resources.moneda;
            this.btnCalcular.Location = new System.Drawing.Point(561, 157);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(25, 26);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolclick.SetToolTip(this.btnCalcular, "Para calcular el sueldo del empleado actual");
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.BackgroundImage = global::Salario_Empleados.Properties.Resources.cerrar;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnSalir.Location = new System.Drawing.Point(600, 156);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(20, 20);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolclick.SetToolTip(this.btnSalir, "Para cerrar el programa");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // imgcargo
            // 
            this.imgcargo.Location = new System.Drawing.Point(77, 14);
            this.imgcargo.Name = "imgcargo";
            this.imgcargo.Size = new System.Drawing.Size(151, 154);
            this.imgcargo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgcargo.TabIndex = 0;
            this.imgcargo.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.BackgroundImage = global::Salario_Empleados.Properties.Resources.Guardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(602, 185);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(20, 20);
            this.btnGuardar.TabIndex = 13;
            this.toolclick.SetToolTip(this.btnGuardar, "Para guardar el registro actual");
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRegistros
            // 
            this.btnRegistros.BackgroundImage = global::Salario_Empleados.Properties.Resources.marcadab;
            this.btnRegistros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistros.FlatAppearance.BorderSize = 0;
            this.btnRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistros.Location = new System.Drawing.Point(602, 8);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(18, 18);
            this.btnRegistros.TabIndex = 0;
            this.toolclick.SetToolTip(this.btnRegistros, "Para ver el registro de todos lo empleados");
            this.btnRegistros.UseVisualStyleBackColor = true;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.ControlBox = false;
            this.Controls.Add(this.barraSuperior);
            this.Controls.Add(this.barraMedia);
            this.Controls.Add(this.barraInferior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "General";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caluadora de salarios";
            this.Load += new System.EventHandler(this.General_Load);
            this.barraSuperior.ResumeLayout(false);
            this.barraSuperior.PerformLayout();
            this.barraInferior.ResumeLayout(false);
            this.barraInferior.PerformLayout();
            this.pnRegistros.ResumeLayout(false);
            this.barraMedia.ResumeLayout(false);
            this.barraMedia.PerformLayout();
            this.grupoInfoPersonal.ResumeLayout(false);
            this.grupoInfoPersonal.PerformLayout();
            this.grupoEfectividad.ResumeLayout(false);
            this.grupoEfectividad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medidonumerohoras)).EndInit();
            this.grupoInfoempresarial.ResumeLayout(false);
            this.grupoInfoempresarial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDinero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcargo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.Label tituloSuperior;
        private System.Windows.Forms.Panel barraInferior;
        private System.Windows.Forms.Panel barraMedia;
        private System.Windows.Forms.GroupBox grupoEfectividad;
        private System.Windows.Forms.TrackBar medidonumerohoras;
        private System.Windows.Forms.GroupBox grupoInfoempresarial;
        private System.Windows.Forms.Label tituloCargoEmpleado;
        private System.Windows.Forms.Label tituloFechaingreso;
        private System.Windows.Forms.DateTimePicker fechaingresoempleado;
        private System.Windows.Forms.ComboBox listcomboboxcargosempleados;
        private System.Windows.Forms.GroupBox grupoInfoPersonal;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.RadioButton radioMasculino;
        private System.Windows.Forms.RadioButton radioFemenino;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtIdentidficacion;
        private System.Windows.Forms.Label titulohorastrabajadas;
        private System.Windows.Forms.Label horastrabajadasporsemana;
        private System.Windows.Forms.PictureBox imgDinero;
        private System.Windows.Forms.TextBox txtventastotal;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox imgcargo;
        private System.Windows.Forms.Label infoHorasExtras;
        private System.Windows.Forms.Label infoSeguridadsocial;
        private System.Windows.Forms.Label infoValortotaldevengado;
        private System.Windows.Forms.Label infoSubsidiodetransporte;
        private System.Windows.Forms.Label InfoValorBeneficios;
        private System.Windows.Forms.Label infoValorcomisiones;
        private System.Windows.Forms.Label infoSueldoBase;
        private System.Windows.Forms.Panel lineaNombre;
        private System.Windows.Forms.Panel lineaIdentificacion;
        private System.Windows.Forms.Panel lineaValor;
        private System.Windows.Forms.Label msnError;
        private System.Windows.Forms.Label impSaldoBase;
        private System.Windows.Forms.Label impcomisiones;
        private System.Windows.Forms.Label impValortotaldevengado;
        private System.Windows.Forms.Label impSeguridadsocial;
        private System.Windows.Forms.Label impHorasExtras;
        private System.Windows.Forms.Label impSubsidiodetransporte;
        private System.Windows.Forms.Label impValorbeneficios;
        private System.Windows.Forms.Label empleado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegistros;
        private System.Windows.Forms.Panel pnRegistros;
        private System.Windows.Forms.ListView listaRegistros;
        private System.Windows.Forms.ColumnHeader listviewnombre;
        private System.Windows.Forms.ColumnHeader listviewcedula;
        private System.Windows.Forms.ColumnHeader listviewgenero;
        private System.Windows.Forms.ColumnHeader listviewfecha;
        private System.Windows.Forms.ColumnHeader listviewcargo;
        private System.Windows.Forms.Button btncerrarRegistros;
        private System.Windows.Forms.Button btninfo;
        private System.Windows.Forms.ToolTip toolclick;
    }
}