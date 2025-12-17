using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HerenciaMaster.Clases;
using System.Data.SqlClient;


namespace HerenciaMaster
{
    public partial class FrmConsultar : Form
    {
        public delegate void pasar(string dato);
        public event pasar pasado;

        DataTable dt = new DataTable();
        public string elcodigo;
        public FrmConsultar()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //this.Hide();
            if (String.IsNullOrEmpty(Convert.ToString(lblcoddigo.Text))) { return; }
            pasado(Convert.ToString(lblcoddigo.Text));
            this.Dispose();
        }

        #region"Consultar top 50 reg Activos"
        public int ConsultaGeneral(int opc,String Nombres,string sqlProcedure )
        {
            try
            {
      dt.Clear(); //dataGridView1.Rows.Clear();  
            ClsConexion cone = new ClsConexion(); cone.Conect();
            using (SqlConnection cn = new SqlConnection(cone.Laconexion))
            {
            if (cn.State == ConnectionState.Closed) {cn.Open(); }
            SqlCommand cmd = new SqlCommand(sqlProcedure, cn); //SpConsultaGeneral
                SqlDataAdapter da=new SqlDataAdapter(sqlProcedure,cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (Nombres == "") { opc = 1; } // si es opc=3 q coja lo q yo le mando osea el codigo
                da.SelectCommand.Parameters.Add("@opc", SqlDbType.Int).Value=opc;
                if(Nombres!="") { da.SelectCommand.Parameters.Add("@Nombres", SqlDbType.VarChar,60).Value=Nombres; }
                if (opc== 3) { da.SelectCommand.Parameters.Add("@codigo", SqlDbType.VarChar, 20).Value = txtcodigo.Text.Trim(); }
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
               

            }
            }catch(Exception t3)
            {
                Console.WriteLine(t3.Message); return 0;
            }
      

            return opc;
        }

        #endregion

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            try
            {
                ConsultaGeneral(1,txtnombre.Text.Trim(), "SpConsultaGeneral");
            }catch(Exception y2)
            {
                MessageBox.Show(y2.Message);
                return;
            }
          
           
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            if (txtnombre.Text != "")
            {
                ConsultaGeneral(2, txtnombre.Text.Trim(), "SpConsultaGeneral");
            }
          
          
        }  // fin del TextChanged

 

            private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    if (txtnombre.Text == "")
                    {
                        ConsultaGeneral(1, txtnombre.Text.Trim(), "SpConsultaGeneral");
                    }
                }

            }

            private void txtcodigo_TextChanged(object sender, EventArgs e)
            {
                if (this.txtcodigo.Text != "")
                {
                    ConsultaGeneral(3, "zzzzzz", "SpConsultaGeneral");
                }
            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                elcodigo = this.dataGridView1.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                //string contactnumber = this.dataGridView1.Rows[e.RowIndex].Cells["ContactNumber"].Value.ToString();
                lblcoddigo.Text = elcodigo;
                if (String.IsNullOrEmpty(Convert.ToString(lblcoddigo.Text))) { return; }
                pasado(Convert.ToString(lblcoddigo.Text));
                this.Dispose();

                if (e.ColumnIndex == 0) //3
                {
                    //da.DeleteCommand = new SqlCommand("Delete from algo where xxxxx = '" + contactname.ToString() + "', and ContactNumber ='" + contactnumber.ToString() + "'", connection);
                    //connection.Open();
                    //da.DeleteCommand.ExecuteNonQuery();
                    //connection.Close();
                }

            }// fin de  dataGridView1_CellContentClick
        

    }
}
