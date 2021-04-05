namespace Salario_Empleados
{
    partial class Inicio_de_Sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio_de_Sesion));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.msnError = new System.Windows.Forms.Label();
            this.panelaside = new System.Windows.Forms.Panel();
            this.imagenaside = new System.Windows.Forms.PictureBox();
            this.PanelUtil = new System.Windows.Forms.Panel();
            this.pncontenedor = new System.Windows.Forms.Panel();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnUsuario = new System.Windows.Forms.Panel();
            this.imgusuario = new System.Windows.Forms.PictureBox();
            this.pnstadoUsuario = new System.Windows.Forms.Panel();
            this.pnContraseña = new System.Windows.Forms.Panel();
            this.imgContraseña = new System.Windows.Forms.PictureBox();
            this.pnstadoContraseña = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.panelaside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenaside)).BeginInit();
            this.PanelUtil.SuspendLayout();
            this.pncontenedor.SuspendLayout();
            this.paneltitulo.SuspendLayout();
            this.pnUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgusuario)).BeginInit();
            this.pnContraseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(64, 8);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(169, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.txtContraseña.ForeColor = System.Drawing.Color.Black;
            this.txtContraseña.Location = new System.Drawing.Point(64, 7);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(0);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(169, 20);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // msnError
            // 
            this.msnError.AutoSize = true;
            this.msnError.BackColor = System.Drawing.Color.Transparent;
            this.msnError.Enabled = false;
            this.msnError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msnError.ForeColor = System.Drawing.Color.DodgerBlue;
            this.msnError.Location = new System.Drawing.Point(15, 153);
            this.msnError.Name = "msnError";
            this.msnError.Size = new System.Drawing.Size(47, 13);
            this.msnError.TabIndex = 4;
            this.msnError.Text = "msnerror";
            this.msnError.Visible = false;
            // 
            // panelaside
            // 
            this.panelaside.BackColor = System.Drawing.Color.Black;
            this.panelaside.Controls.Add(this.imagenaside);
            this.panelaside.Enabled = false;
            this.panelaside.Location = new System.Drawing.Point(0, 0);
            this.panelaside.Name = "panelaside";
            this.panelaside.Size = new System.Drawing.Size(158, 186);
            this.panelaside.TabIndex = 5;
            // 
            // imagenaside
            // 
            this.imagenaside.Enabled = false;
            this.imagenaside.Image = global::Salario_Empleados.Properties.Resources.Persona2;
            this.imagenaside.Location = new System.Drawing.Point(21, 32);
            this.imagenaside.Name = "imagenaside";
            this.imagenaside.Size = new System.Drawing.Size(124, 122);
            this.imagenaside.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenaside.TabIndex = 0;
            this.imagenaside.TabStop = false;
            // 
            // PanelUtil
            // 
            this.PanelUtil.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelUtil.Controls.Add(this.pncontenedor);
            this.PanelUtil.Location = new System.Drawing.Point(175, 0);
            this.PanelUtil.Name = "PanelUtil";
            this.PanelUtil.Size = new System.Drawing.Size(289, 186);
            this.PanelUtil.TabIndex = 6;
            // 
            // pncontenedor
            // 
            this.pncontenedor.BackColor = System.Drawing.Color.White;
            this.pncontenedor.Controls.Add(this.paneltitulo);
            this.pncontenedor.Controls.Add(this.pnUsuario);
            this.pncontenedor.Controls.Add(this.pnContraseña);
            this.pncontenedor.Controls.Add(this.btnCerrar);
            this.pncontenedor.Controls.Add(this.btnIniciar);
            this.pncontenedor.Controls.Add(this.msnError);
            this.pncontenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pncontenedor.Location = new System.Drawing.Point(3, 0);
            this.pncontenedor.Name = "pncontenedor";
            this.pncontenedor.Size = new System.Drawing.Size(286, 186);
            this.pncontenedor.TabIndex = 0;
            this.pncontenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pncontenedor_MouseDown_1);
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.SystemColors.Highlight;
            this.paneltitulo.Controls.Add(this.label1);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(286, 33);
            this.paneltitulo.TabIndex = 6;
            this.paneltitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltitulo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(77, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iniciar sesión";
            // 
            // pnUsuario
            // 
            this.pnUsuario.BackColor = System.Drawing.Color.White;
            this.pnUsuario.Controls.Add(this.imgusuario);
            this.pnUsuario.Controls.Add(this.txtUsuario);
            this.pnUsuario.Controls.Add(this.pnstadoUsuario);
            this.pnUsuario.Location = new System.Drawing.Point(19, 66);
            this.pnUsuario.Name = "pnUsuario";
            this.pnUsuario.Size = new System.Drawing.Size(258, 30);
            this.pnUsuario.TabIndex = 0;
            // 
            // imgusuario
            // 
            this.imgusuario.Enabled = false;
            this.imgusuario.Image = global::Salario_Empleados.Properties.Resources.personamini;
            this.imgusuario.Location = new System.Drawing.Point(42, 5);
            this.imgusuario.Name = "imgusuario";
            this.imgusuario.Size = new System.Drawing.Size(20, 20);
            this.imgusuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgusuario.TabIndex = 1;
            this.imgusuario.TabStop = false;
            // 
            // pnstadoUsuario
            // 
            this.pnstadoUsuario.BackColor = System.Drawing.Color.LawnGreen;
            this.pnstadoUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnstadoUsuario.Enabled = false;
            this.pnstadoUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnstadoUsuario.Name = "pnstadoUsuario";
            this.pnstadoUsuario.Size = new System.Drawing.Size(14, 30);
            this.pnstadoUsuario.TabIndex = 0;
            // 
            // pnContraseña
            // 
            this.pnContraseña.Controls.Add(this.imgContraseña);
            this.pnContraseña.Controls.Add(this.txtContraseña);
            this.pnContraseña.Controls.Add(this.pnstadoContraseña);
            this.pnContraseña.Location = new System.Drawing.Point(19, 92);
            this.pnContraseña.Name = "pnContraseña";
            this.pnContraseña.Size = new System.Drawing.Size(258, 30);
            this.pnContraseña.TabIndex = 1;
            // 
            // imgContraseña
            // 
            this.imgContraseña.Enabled = false;
            this.imgContraseña.Image = global::Salario_Empleados.Properties.Resources.pasword;
            this.imgContraseña.Location = new System.Drawing.Point(42, 5);
            this.imgContraseña.Name = "imgContraseña";
            this.imgContraseña.Size = new System.Drawing.Size(20, 20);
            this.imgContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgContraseña.TabIndex = 3;
            this.imgContraseña.TabStop = false;
            // 
            // pnstadoContraseña
            // 
            this.pnstadoContraseña.BackColor = System.Drawing.Color.LawnGreen;
            this.pnstadoContraseña.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnstadoContraseña.Enabled = false;
            this.pnstadoContraseña.Location = new System.Drawing.Point(0, 0);
            this.pnstadoContraseña.Name = "pnstadoContraseña";
            this.pnstadoContraseña.Size = new System.Drawing.Size(14, 30);
            this.pnstadoContraseña.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::Salario_Empleados.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(199, 140);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 28);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciar.Location = new System.Drawing.Point(232, 147);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(0);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(45, 18);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Inicio_de_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(464, 183);
            this.Controls.Add(this.panelaside);
            this.Controls.Add(this.PanelUtil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio_de_Sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Inicio_de_Sesion_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Inicio_de_Sesion_MouseDown);
            this.panelaside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagenaside)).EndInit();
            this.PanelUtil.ResumeLayout(false);
            this.pncontenedor.ResumeLayout(false);
            this.pncontenedor.PerformLayout();
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            this.pnUsuario.ResumeLayout(false);
            this.pnUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgusuario)).EndInit();
            this.pnContraseña.ResumeLayout(false);
            this.pnContraseña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgContraseña)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label msnError;
        private System.Windows.Forms.Panel panelaside;
        private System.Windows.Forms.PictureBox imagenaside;
        private System.Windows.Forms.Panel PanelUtil;
        private System.Windows.Forms.Panel pncontenedor;
        private System.Windows.Forms.Panel pnUsuario;
        private System.Windows.Forms.Panel pnContraseña;
        private System.Windows.Forms.Panel pnstadoUsuario;
        private System.Windows.Forms.Panel pnstadoContraseña;
        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.PictureBox imgusuario;
        private System.Windows.Forms.PictureBox imgContraseña;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
    }
}

