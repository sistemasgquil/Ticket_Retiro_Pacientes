namespace HerenciaMaster
{
    partial class FrmLogeo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.errorProviderb1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderb1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(152, 118);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(101, 23);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(152, 37);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(162, 20);
            this.txtuser.TabIndex = 3;
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(152, 75);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(162, 20);
            this.txtclave.TabIndex = 4;
            this.txtclave.TextChanged += new System.EventHandler(this.txtclave_TextChanged);
            this.txtclave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtclave_KeyPress);
            // 
            // errorProviderb1
            // 
            this.errorProviderb1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(298, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir Pruebas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmLogeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 145);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogeo";
            this.ShowIcon = false;
            this.Text = "Logeo de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.ErrorProvider errorProviderb1;
        private System.Windows.Forms.Button button1;
    }
}