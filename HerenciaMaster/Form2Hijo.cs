using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Reporting.WinForms;
using System.Net;
using HerenciaMaster.Clases;
using System.Data.SqlClient;

namespace HerenciaMaster
{
    public partial class Form2Hijo : Form
    {
        public delegate void pasar(int numero);
        public event pasar pasado;

        int bandera;

        int n1, n2;
        public int s;
        public Form2Hijo()
        {
            InitializeComponent();
        }


        #region"datos del informe"
        public class CustomReportCredentials : IReportServerCredentials
        {
            private string _UserName;
            private string _PassWord;
            private string _DomainName;

            public CustomReportCredentials(string UserName, string PassWord, string DomainName)
            {
                _UserName = UserName;
                _PassWord = PassWord;
                _DomainName = DomainName;
            }

            public System.Security.Principal.WindowsIdentity ImpersonationUser
            {
                get { return null; }
            }

            public System.Net.ICredentials NetworkCredentials
            {
                get { return new System.Net.NetworkCredential(_UserName, _PassWord, _DomainName); }
            }

            public bool GetFormsCredentials(out System.Net.Cookie authCookie, out string user,
             out string password, out string authority)
            {
                authCookie = null;
                user = password = authority = null;
                return false;
            }
        }

        #endregion

        #region" Consulta combos"
        
        private string FuncionConsultaCombo(string sql, ComboBox Combo, string valor, string mostrar, string nombTabla)
        {
            //*********** consulta el combo  *************
           
            ClsConexion cone = new ClsConexion(); cone.Conect();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, cone.Laconexion);
          //  int co_min; string nom_min = "";
            DataSet Ministerios = new DataSet();
            adapter.Fill(Ministerios, nombTabla);//"ministerio"
            Combo.DataSource = Ministerios.Tables[nombTabla];
            if (Ministerios.Tables[nombTabla].Rows.Count <= 0) { return null; }
            Combo.ValueMember = valor;
            Combo.DisplayMember = mostrar;

            return sql;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = 15; n2 = 6;
            s = n1 + n2;

            MessageBox.Show(Convert.ToString(s));
              // pasado(Convert.ToInt32(s));//textBox1.Text  //  SI FUNCIONA DE AQUI LO MANDO  AL FORM1
                this.Dispose();
        }

        public static bool IsNullOrEmpty(int value) { return true; }

        private void Form2Hijo_Load(object sender, EventArgs e)
        {
            try
            {
  FuncionConsultaCombo("SELECT co_cod,tx_des FROM DBSAD..SAD_MINISTERIO(nolock)", this.cmbMinisterio, "co_cod", "tx_des","ministerio");
            
 FuncionConsultaCombo("SELECT co_cod,rtrim(tx_ape)+' '+rtrim(tx_nom) tx_des,bd_est FROM dbsad..SAD_NOMINAM(nolock) WHERE bd_est = 1 and co_sed in(1,5,6,12)  and co_fun=1 union all SELECT 0 as co_cod,'NINGUNO'tx_des,1 bd_est order by 1", this.CmbPastor, "co_cod", "tx_des","pastor");
            
            }catch(Exception e1)
            {
                MessageBox.Show("Hubo un error; " + e1.Message); return;
            }
              // ListViewItem lista = new ListViewItem();
            listView1.Columns.Add("i", 20, HorizontalAlignment.Left);
            for(int i=0;i<7;i++)
            {
                ListViewItem lista;
                lista = listView1.Items.Add(Convert.ToString(i));
              
               
            }
          
        } // FIN DEL lOAD

        private void Form2Hijo_MouseMoved(object sender, EventArgs e)
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem lista in listView1.SelectedItems)
            {
                for (int i = 0; i < 7; i++)
                {
                    listView1.Items[i].BackColor = Color.White;// listView1.Items.Clear(); //limpio todo
                }
               // if (lista.Selected == true) { MessageBox.Show("Valor:" + lista.Text); lista.Selected = false; }
                lista.Selected = false;
                lista.BackColor = Color.Orange; //  lista.Remove();  // Elimina Registros
                
            }
      

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            //this.Text = "..INFORME PSICOLOGICO .. DE:"+ txtNombres.Text.Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #region"Validar blancos"
        public bool validar()
        {
            errorProvider1.Clear();
            if (txcodigo.Text == "") { errorProvider1.SetError(txcodigo, "Campo importante llenelo."); txcodigo.Focus(); return false; }
            if (string.IsNullOrEmpty(txtNombres.Text))
            {
                MessageBox.Show("Nombres y apellidos vacios");
                if (txtNombres.Text == "") { errorProvider1.SetError(txtNombres, "Campo importante llenelo."); txtNombres.Focus(); }
                return false;
            }
            if (txtedad.Text == "") { errorProvider1.SetError(txtedad, "Campo importante llenelo."); txtedad.Focus(); return false; }

            return true;
        }
        #endregion

        #region"Data a pasar a la clase"
        private void PasaDataClases(int opc)
        {
            ClsPsico proceso = new ClsPsico();
            
            proceso.codigo = txcodigo.Text.Trim();
            proceso.Nombres = txtNombres.Text.Trim();
            proceso.fe_nac = dtpnac.Value;
            proceso.edad = Convert.ToInt32(txtedad.Text.Trim());
            proceso.est_civil = txtcivil.Text;
            proceso.conyuge = txtconyuge.Text.Trim();
            proceso.hijos = Convert.ToInt32(this.txthijo.Text.Trim());
            proceso.est_civil = txtcivil.Text.Trim(); //@est_civil
            proceso.grado_instru = txtgrado.Text.Trim();
            proceso.domicilio = txtdir.Text.Trim();
            proceso.telf_fijo = txtfijo.Text.Trim();
            proceso.telf_cel = txtcel.Text.Trim();
            proceso.ministerio = Convert.ToInt32(cmbMinisterio.SelectedValue);
            proceso.pastor = Convert.ToInt32(CmbPastor.SelectedValue);
            proceso.cursos_eclesiasticos = txtcursoecle.Text.Trim();
            proceso.pruebas_psicom = txtpruebaspsico.Text.Trim();
            proceso.motivo_entrev = txtmotivo.Text.Trim();
            proceso.antec_familiar = txtantecedente.Text.Trim();
            proceso.problemat_actual = txtproblematica.Text.Trim();
            proceso.analisis_clinico = txtanalisis.Text.Trim();
            proceso.resultados = txtResultados.Text.Trim();
            if (bandera == 1) { proceso.estado = bandera; }
            //  *************  Lllamo a mi clase para que haga la magia, del mantenimiento by Acueva 22:47  22/03/2017
            proceso.ExecuteSqlTransaction("SpManteInforme", opc); //opc=1 graba o modifica segun sea el caso

            if (proceso.band == 0)
            {
                MessageBox.Show("Ocurrio un error en el proceso.", "Mensaje del Sistema");
            }
            else
            {
                MessageBox.Show("Grabado con exito. " + txtNombres.Text.Trim(), "Mensaje del Sistema");
                limpiar();
            }
        }
        #endregion

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar() == false) { MessageBox.Show("Uno de tus campos esta vacio o tiene errores", "Mensaje al Ususario"); return; }
                bandera = 1; // osea la opc=1
                PasaDataClases(bandera);

            }catch(Exception e5)
            {
                MessageBox.Show("Hubo un error; " + e5.Message,"Mensaje del Sistema"); return;
            }
        }

        #region"Limpiar Datos"
        private void limpiar()
        {
            txtedad.Text = ""; txtgrado.Text = "";
            txtfijo.Text = "";
            txtNombres.Text = "";
            txtproblematica.Text = "";
            txtpruebaspsico.Text = "";
            txtResultados.Text = "";
            txtanalisis.Clear();
            txtproblematica.Clear();
            txtantecedente.Clear();
            txtmotivo.Clear();
            txtcursoecle.Clear();
            txtcel.Clear();
            txtdir.Clear();
            txthijo.Text = "0";
            txtconyuge.Clear();
            txtcivil.Clear(); txcodigo.Clear(); txcodigo.Focus();
            cmbMinisterio.SelectedIndex = 0; CmbPastor.SelectedIndex = 0;
        }
        #endregion

        private void button2_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        #region"Consulta master general PARA ESTA PANTALLA"
        private string ConsultaGeneral(string variable)
        {
            ClsConexion cone = new ClsConexion(); cone.Conect(); string nombTabla = "tabla";
            string sql = "Select top(1) codigo,Nombres,fe_nac,edad,est_civil,conyuge,hijos,grado_instru,domicilio,";
            sql = sql + "telf_fijo,telf_cel,ministerio,pastor,cursos_eclesiasticos,pruebas_psicom,motivo_entrev,";
            sql = sql + "antec_familiar,problemat_actual,analisis_clinico,resultados,estado from INFORME (Nolock)";
            sql=sql+ " where estado=1 and codigo='" + variable + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, cone.Laconexion);
                DataSet DataGeneral = new DataSet();
                adapter.Fill(DataGeneral, nombTabla);

                if (DataGeneral.Tables[nombTabla].Rows.Count <= 0) { return null; }
 
                foreach (DataRow pRow in DataGeneral.Tables[nombTabla].Rows)
                {
                    txcodigo.Text = Convert.ToString(pRow["codigo"]);
                    txtNombres.Text = Convert.ToString(pRow["Nombres"]);
                    this.dtpnac.Value = Convert.ToDateTime(pRow["fe_nac"]);
                    txtedad.Text = Convert.ToString(pRow["edad"]);
                    txtcivil.Text = Convert.ToString(pRow["est_civil"]);
                    txtconyuge.Text = Convert.ToString(pRow["conyuge"]);
                    txthijo.Text = Convert.ToString(pRow["hijos"]);
                    txtgrado.Text = Convert.ToString(pRow["grado_instru"]);
                    txtdir.Text = Convert.ToString(pRow["domicilio"]);
                    txtfijo.Text = Convert.ToString(pRow["telf_fijo"]);
                    txtcel.Text = Convert.ToString(pRow["telf_cel"]);
                    cmbMinisterio.SelectedValue = Convert.ToInt32(pRow["ministerio"]);
                    CmbPastor.SelectedValue = Convert.ToInt32(pRow["pastor"]);
                    txtcursoecle.Text = Convert.ToString(pRow["cursos_eclesiasticos"]);
                    txtpruebaspsico.Text = Convert.ToString(pRow["pruebas_psicom"]);
                    txtmotivo.Text = Convert.ToString(pRow["motivo_entrev"]);
                    txtantecedente.Text = Convert.ToString(pRow["antec_familiar"]);
                    txtproblematica.Text = Convert.ToString(pRow["problemat_actual"]);//problemat_actual
                    txtanalisis.Text = Convert.ToString(pRow["analisis_clinico"]);
                    txtResultados.Text = Convert.ToString(pRow["resultados"]); //resultados
                    //estado
                }
                return variable;
        }

        #endregion

        public void ejecutar(string dato)
        {// ejecuta la consulta, si biene el dato lleno de la pantalla consultar
            this.textBox1.Text = Convert.ToString(dato);
            if (dato != "" || dato != "0")
            {
                ConsultaGeneral(dato);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultar cons = new FrmConsultar();
             cons.pasado += new FrmConsultar.pasar(ejecutar);  //llamada simple
            cons.Show();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿ Seguro que desea eliminar ? "+txcodigo.Text.Trim(), "Mensaje del Sistema", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bandera = 2;
                    PasaDataClases(bandera); // opc=2 Actualizar
                }
                else if (dialogResult == DialogResult.No)
                {
                    txcodigo.Focus();
                }
            }catch(Exception y1)
            {
                MessageBox.Show("Hubo un error; " + y1); return;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
             
                    if (txcodigo.Text != "") { ConsultaGeneral(txcodigo.Text.Trim()); }
               }
            catch (Exception h)
            {
                Console.WriteLine(h.Message);
                return;
            }
        }

        private void txtproblematica_TextChanged(object sender, EventArgs e)
        {

        }

	

    }
}
