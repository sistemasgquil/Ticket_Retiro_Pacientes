namespace HerenciaMaster
{
    partial class FrmConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultar));
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.lblcoddigo = new System.Windows.Forms.Label();
            this.toolTipCons1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(406, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.toolTipCons1.SetToolTip(this.btnSalir, "Salir y llevar Datos Seleccionados..");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 299);
            this.dataGridView1.TabIndex = 1;
            this.toolTipCons1.SetToolTip(this.dataGridView1, "Doble click en el dato..");
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombres/Apellidos:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(164, 35);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(217, 20);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(164, 6);
            this.txtcodigo.MaxLength = 20;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(217, 20);
            this.txtcodigo.TabIndex = 5;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(26, 364);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(37, 13);
            this.lblRegistros.TabIndex = 6;
            this.lblRegistros.Text = "Reg#:";
            // 
            // lblcoddigo
            // 
            this.lblcoddigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblcoddigo.AutoSize = true;
            this.lblcoddigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoddigo.Location = new System.Drawing.Point(88, 364);
            this.lblcoddigo.Name = "lblcoddigo";
            this.lblcoddigo.Size = new System.Drawing.Size(14, 13);
            this.lblcoddigo.TabIndex = 7;
            this.lblcoddigo.Text = "0";
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 386);
            this.Controls.Add(this.lblcoddigo);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "... Consulta General ...";
            this.Load += new System.EventHandler(this.FrmConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblRegistros;
        public System.Windows.Forms.Label lblcoddigo;
        private System.Windows.Forms.ToolTip toolTipCons1;
    }
}