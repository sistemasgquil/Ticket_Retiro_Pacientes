namespace HerenciaMaster
{
    partial class Form3Hijo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3Hijo));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHoraIni = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtevento = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnImprimir = new System.Windows.Forms.Button();
            this.toolTipAgendas1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblcoddigo = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Desde:";
            this.label1.Visible = false;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(15, 95);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 1;
            this.dtpFechaDesde.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Hasta:";
            this.label2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(564, 170);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora Inicio:";
            // 
            // dtpHoraIni
            // 
            this.dtpHoraIni.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraIni.Location = new System.Drawing.Point(95, 204);
            this.dtpHoraIni.Name = "dtpHoraIni";
            this.dtpHoraIni.Size = new System.Drawing.Size(93, 20);
            this.dtpHoraIni.TabIndex = 6;
            this.toolTipAgendas1.SetToolTip(this.dtpHoraIni, "hora desde (Inicial)..");
            this.dtpHoraIni.Value = new System.DateTime(2017, 3, 24, 0, 0, 0, 0);
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(95, 229);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.Size = new System.Drawing.Size(93, 20);
            this.dtpHoraFin.TabIndex = 8;
            this.toolTipAgendas1.SetToolTip(this.dtpHoraFin, "Hora final o  hora hasta..");
            this.dtpHoraFin.Value = new System.DateTime(2017, 3, 24, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hora Fin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descripción:";
            // 
            // txtevento
            // 
            this.txtevento.Location = new System.Drawing.Point(95, 251);
            this.txtevento.MaxLength = 100;
            this.txtevento.Multiline = true;
            this.txtevento.Name = "txtevento";
            this.txtevento.Size = new System.Drawing.Size(350, 36);
            this.txtevento.TabIndex = 10;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(260, 76);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            this.toolTipAgendas1.SetToolTip(this.monthCalendar1, "Su Fecha...");
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(17, 7);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(68, 57);
            this.btnLimpiar.TabIndex = 13;
            this.toolTipAgendas1.SetToolTip(this.btnLimpiar, "Limpiar (Para Nuevo Registro)");
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(214, 7);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(68, 57);
            this.btnConsultar.TabIndex = 15;
            this.toolTipAgendas1.SetToolTip(this.btnConsultar, "Consultar..");
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(313, 7);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(68, 57);
            this.btnEliminar.TabIndex = 16;
            this.toolTipAgendas1.SetToolTip(this.btnEliminar, "Eliminar Registro.");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.Location = new System.Drawing.Point(116, 7);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(68, 57);
            this.btnGrabar.TabIndex = 14;
            this.toolTipAgendas1.SetToolTip(this.btnGrabar, "Grabar..");
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(409, 7);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 57);
            this.btnSalir.TabIndex = 17;
            this.toolTipAgendas1.SetToolTip(this.btnSalir, "SALIR..");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Location = new System.Drawing.Point(493, 468);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "< Imprimir >";
            this.toolTipAgendas1.SetToolTip(this.btnImprimir, "Impresión Rápida..");
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Visible = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblcoddigo
            // 
            this.lblcoddigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblcoddigo.AutoSize = true;
            this.lblcoddigo.BackColor = System.Drawing.Color.Moccasin;
            this.lblcoddigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoddigo.Location = new System.Drawing.Point(12, 474);
            this.lblcoddigo.Name = "lblcoddigo";
            this.lblcoddigo.Size = new System.Drawing.Size(14, 13);
            this.lblcoddigo.TabIndex = 19;
            this.lblcoddigo.Text = "0";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(15, 134);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 20;
            this.toolTipAgendas1.SetToolTip(this.dtpFechaHasta, "Fecha hasta..");
            this.dtpFechaHasta.Visible = false;
            // 
            // Form3Hijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 491);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.lblcoddigo);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txtevento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpHoraFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpHoraIni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3Hijo";
            this.Text = "AGENDAS";
            this.Load += new System.EventHandler(this.Form3Hijo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHoraIni;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtevento;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ToolTip toolTipAgendas1;
        public System.Windows.Forms.Label lblcoddigo;
        public System.Windows.Forms.DateTimePicker dtpFechaHasta;
    }
}