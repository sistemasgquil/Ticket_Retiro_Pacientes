namespace HerenciaMaster
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTipAC1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblnivel = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFundacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(14, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "INFORME PSICOLOGICO";
            this.toolTipAC1.SetToolTip(this.button1, "Nuevo Informe..");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Location = new System.Drawing.Point(14, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "AGENDAS";
            this.toolTipAC1.SetToolTip(this.button2, "Agendas..");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.SystemColors.Info;
            this.BtnMenu.Location = new System.Drawing.Point(12, 382);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(105, 71);
            this.BtnMenu.TabIndex = 2;
            this.BtnMenu.Text = "VERSIÓN";
            this.toolTipAC1.SetToolTip(this.BtnMenu, "Versión de la aplicacion..");
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(12, 478);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 72);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.Location = new System.Drawing.Point(123, 12);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(625, 623);
            this.panelContenedor.TabIndex = 4;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(14, 326);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(0, 13);
            this.lblcodigo.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Location = new System.Drawing.Point(14, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 73);
            this.button3.TabIndex = 6;
            this.button3.Text = "REPORTES";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblnivel
            // 
            this.lblnivel.AutoSize = true;
            this.lblnivel.Location = new System.Drawing.Point(28, 624);
            this.lblnivel.Name = "lblnivel";
            this.lblnivel.Size = new System.Drawing.Size(10, 13);
            this.lblnivel.TabIndex = 7;
            this.lblnivel.Text = "-";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(29, 583);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(10, 13);
            this.lbluser.TabIndex = 8;
            this.lbluser.Text = "-";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(85, 578);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 563);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nivel:";
            // 
            // btnFundacion
            // 
            this.btnFundacion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFundacion.Location = new System.Drawing.Point(14, 27);
            this.btnFundacion.Name = "btnFundacion";
            this.btnFundacion.Size = new System.Drawing.Size(101, 63);
            this.btnFundacion.TabIndex = 12;
            this.btnFundacion.Text = "FUNDACIÓN";
            this.btnFundacion.UseVisualStyleBackColor = false;
            this.btnFundacion.Click += new System.EventHandler(this.btnFundacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 637);
            this.Controls.Add(this.btnFundacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.lblnivel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "... DEPARTAMENTO PSICOLOGICO ...";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTipAC1;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Label lbluser;
        public System.Windows.Forms.Label lblnivel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFundacion;
    }
}

