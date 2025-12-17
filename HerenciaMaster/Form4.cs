using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using HerenciaMaster.Clases;
using System.Data.SqlClient;

namespace HerenciaMaster
{
    public partial class Form4 : Form
    {
        public delegate void pasar(int numero);
        public event pasar pasado;

        DataTable dtReportes = new DataTable();
        DataTable dtReportes2 = new DataTable();

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(Convert.ToString(textBox1.Text))) { textBox1.Text = "777"; return; }
            //pasado(Convert.ToInt32(textBox1.Text));
            //this.Dispose();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false; radioButton1.Checked = true; groupBox1.Enabled = true; groupBox2.Enabled = false;


            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false; radioButton2.Checked = true; groupBox1.Enabled = false; groupBox2.Enabled = true;
                txtcodigo.Focus();

            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {


            if (this.textBox1.Text == "administrador") { radioButton2.Enabled = true; radioButton2.Enabled = true; } else { radioButton2.Enabled = false; }
           // this.rpvReportes.RefreshReport();
        }

        private void btnRptAgenda_Click(object sender, EventArgs e)
        {
            try
            {
           rpvReportes.LocalReport.DataSources.Clear();
                    rpvReportes.Clear();
                    rpvReportes.LocalReport.ReportEmbeddedResource = "HerenciaMaster.Reportes.RptAgenda.rdlc";
                    List<ReportParameter> _params = new List<ReportParameter>();
                    _params.Add(new ReportParameter("fecha_ini",Convert.ToString(dtpFechaDesde.Value)));
                    _params.Add(new ReportParameter("fecha_fin", Convert.ToString(dtpFechaHasta.Value)));
                    rpvReportes.LocalReport.SetParameters(_params);
                    // ********* proceso q ejecuta consulta ******* DataTable*****  y fin de lqa magia by Acueva 23/03/2017
                    Consultas2("SpConsultaRangoAgenda", 99, "", this.dataGridView1);
                    rpvReportes.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dtReportes2));
                    rpvReportes.RefreshReport();
            }catch(Exception yp)
            {
                MessageBox.Show("Hubo un error en RptAgenda; " + yp.Message); return;
            }
         
        }

        #region"Datatbale Llena Reportes"
        private DataTable Consultas(string sqlProcedure,int opc,string Nombres,DataGridView Grilla)
        {
            try
            {
       ClsConexion cone = new ClsConexion(); cone.Conect();
            using (SqlConnection cn = new SqlConnection(cone.Laconexion))
            {
                if (cn.State == ConnectionState.Closed) { cn.Open(); }
                dtReportes.Clear();
                SqlCommand cmd = new SqlCommand(sqlProcedure, cn); //SpConsultaGeneral
                SqlDataAdapter da = new SqlDataAdapter(sqlProcedure, cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (Nombres == "") { opc = 3; } // si es opc=3 x el codigo
                da.SelectCommand.Parameters.Add("@opc", SqlDbType.Int).Value = opc;
               // if (Nombres != "") { da.SelectCommand.Parameters.Add("@Nombres", SqlDbType.VarChar, 60).Value = Nombres; }
                if (opc == 3) { da.SelectCommand.Parameters.Add("@codigo", SqlDbType.VarChar, 20).Value = txtcodigo.Text.Trim(); }
                da.Fill(dtReportes);
                if (dtReportes.Rows.Count > 0)
                {
                    Grilla.DataSource = dtReportes;
                }             
            }// fin de  using (SqlConnection cn = new SqlConnection(cone.Laconexion))
            }catch(Exception u)
            {
                MessageBox.Show(u.Message); return null;
            }
     
            return dtReportes;
        }

        private DataTable Consultas2(string sqlProcedure, int opc, string Nombres, DataGridView Grilla)
        {
            try
            {
     ClsConexion cone = new ClsConexion(); cone.Conect();
                using (SqlConnection cn = new SqlConnection(cone.Laconexion))
                {
                    if (cn.State == ConnectionState.Closed) { cn.Open(); }
                    dtReportes2.Clear();
                    SqlCommand cmd = new SqlCommand(sqlProcedure, cn); 
                    SqlDataAdapter da = new SqlDataAdapter(sqlProcedure, cn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                 //   da.SelectCommand.Parameters.Add("@opc", SqlDbType.Int).Value = opc;
                    da.SelectCommand.Parameters.Add("@fecha_ini", SqlDbType.Date).Value = Convert.ToString(this.dtpFechaDesde.Value.Date);
                    da.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = Convert.ToString(dtpFechaHasta.Value.Date); 
                    da.Fill(dtReportes2);
                    if (dtReportes2.Rows.Count > 0)
                    {
                        Grilla.DataSource = dtReportes2;
                    }
                }// fin de  using (SqlConnection cn = new SqlConnection(cone.Laconexion))
            }catch (Exception p)
            {
                MessageBox.Show(p.Message); return null;
            }

           
            return dtReportes2;
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcodigo.Text != "") 
                {
                rpvReportes.LocalReport.DataSources.Clear();
                rpvReportes.Clear();
                rpvReportes.LocalReport.ReportEmbeddedResource = "HerenciaMaster.Reportes.RptInforme.rdlc";
                List<ReportParameter> _params = new List<ReportParameter>();
                _params.Add(new ReportParameter("opc", Convert.ToString("3")));
                _params.Add(new ReportParameter("codigo", Convert.ToString(txtcodigo.Text.Trim())));
                rpvReportes.LocalReport.SetParameters(_params);
                // ********* proceso q ejecuta consulta ******* DataTable*****  y fin de lqa magia by Acueva 23/03/2017
                Consultas("SpConsultaGeneral", 3, "",this.dataGridView1);
                rpvReportes.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dtReportes));
                rpvReportes.RefreshReport();
                } // fin de (txtcodigo.Text != "") 
            }
            catch (Exception yp)
            {
                MessageBox.Show("Hubo un error en RptAgenda; " + yp.Message); return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Consultas("SpConsultaGeneral", 3, "",this.dataGridView1);
        }

        private void btnVerAgendas_Click(object sender, EventArgs e)
        {
            Consultas2("SpConsultaRangoAgenda", 99, "", this.dataGridView1);
        }
    }
}
