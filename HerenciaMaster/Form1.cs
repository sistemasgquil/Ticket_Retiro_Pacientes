using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HerenciaMaster
{
    public partial class Form1 : Form
    {
        public int numero;
        public int privilegios;

        //public delegate void pasar(string nivel); // string usuario,
        //public event pasar pasado;

        public Form1()
        {
            InitializeComponent();
            //Form2Hijo fo = new Form2Hijo();
            //lblcodigo.Text = Convert.ToString(fo.s);
            //lblcodigo.Text = Convert.ToString(this.numero);
          
        }

        public void ejecutar(string user, string nivel)//
        {// ejecuta la consulta, si biene el dato lleno de la pantalla logeo
            //  lblnivel.Text = dato;
            if (user != "")
            {
                lbluser.Text = user;
            }

            if (nivel != "")
            {
                lblnivel.Text = nivel;
            }
        }
    
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        #region"Funcion mostrar hijo"
        private void AddFormInPanel(object formHijo,int privilegios)
        {
           
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
           fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        } 
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            // INFORME PSICOLOGICO
            if (this.panelContenedor.Controls.Count > 0) //panel1
                this.panelContenedor.Controls.RemoveAt(0);
            Form2Hijo hijo1 = new Form2Hijo();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.pasado += new Form2Hijo.pasar(ejecutar);
            hijo1.Show();  // SI FUNCIONA... SOLO LO DORMI
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            //Form4 fo = new Form4();
            ////Pasar x delegados https://www.youtube.com/watch?v=gRSc6PPNjvk
            //// Entender lo de delegados:  https://www.youtube.com/watch?v=Ow7Bejyvlt0
            //// para no usar el bendito reporte, mata todo de una vez https://www.youtube.com/watch?v=Li3KKVr24JI
            //fo.pasado += new Form4.pasar(ejecutar);  //llamada simple
            //fo.Show();
            MessageBox.Show("Realizado por Andrés Cueva C Version 1.0 Actualizado:24/03/2017","Mensaje al Usuario");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // AGENDAS
            if (lblnivel.Text == "administrador") { privilegios = 1; } else { privilegios = 0; }
            AddFormInPanel(new Form3Hijo(), privilegios); // lo instancio al objecto formulario.
        }

        public void ejecutar(int numero)
        {
            lblcodigo.Text = Convert.ToString(numero);
           
        }

        public void ejecutar2(string dato)
        {
            lblnivel.Text = Convert.ToString(dato);

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if(lblnivel.Text=="administrador")
            {
                this.button1.Enabled = true;
            }
            else
            {
                this.button1.Enabled = false; 
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            // REPORTES
            if (lblnivel.Text == "administrador") { privilegios = 1; } else { privilegios = 0; }
          
           
           // AddFormInPanel(new Form4(),privilegios); // lo instancio al objecto formulario.

            if (this.panelContenedor.Controls.Count > 0) //panel1
                this.panelContenedor.Controls.RemoveAt(0);
            Form4 hijo1 = new Form4();
            hijo1.textBox1.Text = lblnivel.Text.Trim();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();  // SI FUNCIONA... SOLO LO DORMI

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmLogeo log = new FrmLogeo();
            log.pasado += new FrmLogeo.pasar(ejecutar2);
            //this.lblnivel.Text = log.nivel;
            this.ShowDialog();
        }

        private void btnFundacion_Click(object sender, EventArgs e)
        {
           try
           {
             if (this.panelContenedor.Controls.Count > 0) //panel1
                            this.panelContenedor.Controls.RemoveAt(0);
                         Form5HijoFundacion hijo1 = new Form5HijoFundacion();
                        hijo1.TopLevel = false;
                        hijo1.FormBorderStyle = FormBorderStyle.None;
                        hijo1.Dock = DockStyle.Fill;
                        this.panelContenedor.Controls.Add(hijo1);
                        this.panelContenedor.Tag = hijo1;
                        hijo1.pasado += new Form5HijoFundacion.pasar(ejecutar);
                        hijo1.Show();
           }catch(Exception u)
           {
               MessageBox.Show(u.Message);
           }
            
        }
    }
}
