using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using HerenciaMaster.Clases;

namespace HerenciaMaster
{
    public partial class FrmLogeo : Form
    {
        public delegate void pasar(string nivel); // string usuario,
        public event pasar pasado;
        DataTable dt = new DataTable();



        public string nivel;

        public FrmLogeo()
        {
            InitializeComponent();
        }

        #region"Consultar reg Activos"
        public string ConsultaGeneral(String usuario, String clave, string sqlProcedure)
        {
            try
            {
                dt.Clear();
                ClsConexion cone = new ClsConexion(); cone.Conect();
                using (SqlConnection cn = new SqlConnection(cone.Laconexion))
                {
                    if (cn.State == ConnectionState.Closed) { cn.Open(); }
                    SqlCommand cmd = new SqlCommand(sqlProcedure, cn); //
                    SqlDataAdapter da = new SqlDataAdapter(sqlProcedure, cn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    da.SelectCommand.Parameters.Add("@usuario", SqlDbType.VarChar, 20).Value = usuario;
                    da.SelectCommand.Parameters.Add("@clave", SqlDbType.VarChar, 20).Value = clave;
                  
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        this.Hide();
                        Form1 f = new Form1();
                       // f.pasado1 += new Form1.pasar1(ejecutar());  //llamada simple
                        foreach (DataRow pRow in dt.Rows)
                        {
                            nivel=Convert.ToString(pRow["nivel"]);
                          
                        }

                        f.lbluser.Text = txtuser.Text.Trim();
                        f.lblnivel.Text = nivel.Trim();
                       f.Show();

                       
                    }else
                    {
                        MessageBox.Show("Usuario o clave incorrectas", "Mensaje del Sistema"); 
                    }
                    cn.Close();
                }
            }
            catch (Exception t3)
            {
                MessageBox.Show("Hubo un error; "+ t3.Message); return null;
            }


            return usuario;
        }

        //private void ejecutar2(string usuario, string nivel)
        //{
        //    usuario = txtuser.Text.Trim();
        //    nivel="inivitado";

        //    throw new NotImplementedException();
        //}

        #endregion

     


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            errorProviderb1.Clear();
            if (txtuser.Text == "") { errorProviderb1.SetError(txtuser, "llene el usuario"); return; }
            if (txtclave.Text == "") { errorProviderb1.SetError(txtclave, "llene la Clave"); return; }
            ConsultaGeneral(txtuser.Text.Trim(), txtclave.Text.Trim(),"SpConsultaUsuario");


        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pasado != null) { pasado("dsfsf"); }
            Form1 fox = new Form1();
            fox.lblnivel.Text = "Baggggoooo";
            fox.Show();
           // this.Dispose();
        }

        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
   if (txtclave.Text!="")
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
                errorProviderb1.Clear();
                if (txtuser.Text == "") { errorProviderb1.SetError(txtuser, "llene el usuario"); return; }
                if (txtclave.Text == "") { errorProviderb1.SetError(txtclave, "llene la Clave"); return; }
                ConsultaGeneral(txtuser.Text.Trim(), txtclave.Text.Trim(), "SpConsultaUsuario");
            }
            }
         
        }
    }
}
