using HerenciaMaster.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HerenciaMaster
{
    public partial class Form3Hijo : Form
    {
        int bandera;
        DataTable dt = new DataTable();
        string elcodigo;

        public Form3Hijo()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        #region"Consultar top 50 reg Activos"
        public int ConsultaGeneral(int opc, String evento, string sqlProcedure)
        {
            try
            {
                dt.Clear(); 
                ClsConexion cone = new ClsConexion(); cone.Conect();
                using (SqlConnection cn = new SqlConnection(cone.Laconexion))
                {
                    if (cn.State == ConnectionState.Closed) { cn.Open(); }
                    SqlCommand cmd = new SqlCommand(sqlProcedure, cn); //SpConsultaGeneralAgenda
                    SqlDataAdapter da = new SqlDataAdapter(sqlProcedure, cn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    if (evento != "") { opc = 2; } 
                    da.SelectCommand.Parameters.Add("@opc", SqlDbType.Int).Value = opc;
                    if (opc == 2) { da.SelectCommand.Parameters.Add("@evento", SqlDbType.VarChar, 100).Value = txtevento.Text.Trim(); }
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        btnImprimir.Visible = true;
                        //  dataGridView1.AutoResizeColumns();
                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns[0].Width = 75;
                        dataGridView1.Columns[1].Width = 25; //dia
                        dataGridView1.Columns[2].Width = 30; //mes
                        dataGridView1.Columns[3].Width = 40;//año
                        dataGridView1.Columns[4].Width = 60; //hora ini
                        dataGridView1.Columns[5].Width = 60; //hora fin
                        dataGridView1.Columns[6].Width = 230; //evento
                    }
                    else { btnImprimir.Visible = false; }


                }
            }
            catch (Exception t3)
            {
                Console.WriteLine(t3.Message); return 0;
            }


            return opc;
        }

        #endregion

        private void Form3Hijo_Load(object sender, EventArgs e)
        {
           try
           {
               this.dtpHoraIni.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 30, 0);
               this.dtpHoraFin.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 30, 0);
              // this.dtpFechaHasta.Value = DateTime.Now.Date();

           }catch(Exception y)
           {
               Console.WriteLine(y.Message);
           }
        }

        #region"Limpiar"
        private void limpiar()
        {
            txtevento.Clear(); lblcoddigo.Text = "0";
            

        }
        #endregion
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar(); dataGridView1.DataSource = null; btnImprimir.Visible = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultaGeneral(1, txtevento.Text.Trim(), "SpConsultaGeneralAgenda");
           

        }

        #region"Data a pasar a la clase"
        private void PasaDataClases(int opc)
        {
            ClsAgenda proceso = new ClsAgenda();
            int Elorden = 0;
            
            string eldia = "";
            string code = "";
            if (opc == 2)
            {
                proceso.codigo = Convert.ToInt32(lblcoddigo.Text.Trim());
            }else
            {
                // System.DateTime moment = new System.DateTime();  int second = moment.Second;
                Random rnd1 = new Random(); int Numer = rnd1.Next(9999);
     //   code = Convert.ToString(monthCalendar1.SelectionRange.Start.Year) + Convert.ToString(monthCalendar1.SelectionRange.Start.Month) + Convert.ToString(monthCalendar1.SelectionRange.Start.Day)+ Convert.ToString(DateTime.Now.Date.Second);
                code = Convert.ToString(Numer);
            proceso.codigo = Convert.ToInt32(code);
            }
            
          
            proceso.anio = this.monthCalendar1.SelectionRange.Start.Year; // this.monthCalendar1.TodayDate.Year;
            proceso.mes = this.monthCalendar1.SelectionRange.Start.Month;
            proceso.dia = Convert.ToInt32(this.monthCalendar1.SelectionRange.Start.Day);
            proceso.hora_ini = dtpHoraIni.Text.Trim();
            proceso.hora_fin = dtpHoraFin.Text.Trim();
            proceso.evento = Convert.ToString(this.txtevento.Text.Trim());
            proceso.nivel = "MEDIO"; //@OPCIONAL
            if (bandera == 2) { proceso.estado = 0; } // eliminar
            if (bandera == 1) { proceso.estado = 1; } // actualizar o insertar
            eldia = Convert.ToString(this.monthCalendar1.SelectionRange.Start.DayOfWeek);
            switch (eldia)
            {
                case "Monday": eldia = "Lunes"; Elorden = 1; break;
                case "Tuesday": eldia = "Martes"; Elorden = 2; break;
                case "Wednesday": eldia = "Miercoles"; Elorden = 3; break;
                case "Thursday": eldia = "Jueves"; Elorden = 4; break;
                case "Friday": eldia = "Viernes"; Elorden = 5; break;
                case "Saturday": eldia = "Sabado"; Elorden = 6; break;
                case "Sunday": eldia = "Domingo"; Elorden = 7; break;

                case "Lunes": Elorden = 1; break;
                case "Martes": Elorden = 2; break;
                case "Miercoles": Elorden = 3; break;
                case "Jueves": Elorden = 4; break;
                case "Viernes": Elorden = 5; break;
                case "Sabado": Elorden = 6; break;
                case "Domingo": Elorden = 7; break;
                default :
                    eldia=Convert.ToString(this.monthCalendar1.SelectionRange.Start.DayOfWeek);
                    break;
            }
            if(eldia == "") { MessageBox.Show("Escoga un dia en el calendario."); return; }
            proceso.nomDia = eldia; //Convert.ToString(this.monthCalendar1.SelectionRange.Start.DayOfWeek);
            proceso.orden = Elorden;
            proceso.fecha = Convert.ToDateTime(this.monthCalendar1.SelectionRange.Start.Date);
            proceso.opcion = opc;
     
          
            //  *************  Lllamo a mi clase para que haga la magia.
            proceso.ExecuteSqlTransaction("SpManteAgenda", opc); //opc=1 graba o modifica segun sea el caso

            if (proceso.band == 0)
            {
                MessageBox.Show("Ocurrio un error en el proceso.", "Mensaje del Sistema");
            }
            else
            {
                MessageBox.Show("Grabado con exito. " + txtevento.Text.Trim(), "Mensaje del Sistema");
                limpiar();
            }
        }
        #endregion


        #region"Validar blancos"
        public bool validar()
        {
            errorProvider1.Clear();
            if (txtevento.Text == "") { errorProvider1.SetError(txtevento, "Campo importante llenelo."); txtevento.Focus(); return false; }
           
            return true;
        }
        #endregion

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar() == false) { MessageBox.Show("Uno de tus campos esta vacio o tiene errores", "Mensaje al Ususario"); return; }
                bandera = 1; // osea la opc=1
                PasaDataClases(bandera);

            }
            catch (Exception e5)
            {
                MessageBox.Show("Hubo un error; " + e5.Message, "Mensaje del Sistema"); return;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1) { return; }
            printDocument1.Print();


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Bitmap img = new Bitmap(this.dataGridView1.Width,this.dataGridView1.Height);
                dataGridView1.DrawToBitmap(img,new Rectangle(0,0,this.dataGridView1.Width,this.dataGridView1.Height));
                e.Graphics.DrawImage(img,10,10);
                
            }catch(Exception p)
            {
                MessageBox.Show(p.Message);
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose(); //this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblcoddigo.Text == "0") { MessageBox.Show("No tienes registro valido para borrar."); return; }
                DialogResult dialogResult = MessageBox.Show("¿ Seguro que desea eliminar ? " + lblcoddigo.Text.Trim(), "Mensaje del Sistema", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bandera = 2;
                    PasaDataClases(bandera); // opc=2 eliminar
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.dtpHoraIni.Focus();
                }
            }
            catch (Exception y1)
            {
                MessageBox.Show("Hubo un error; " + y1); return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            elcodigo = this.dataGridView1.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                        lblcoddigo.Text = elcodigo;
            }
            catch(Exception p)
            {
                Console.WriteLine(p.Message);
                return;

            }
            
        }
    }
}
