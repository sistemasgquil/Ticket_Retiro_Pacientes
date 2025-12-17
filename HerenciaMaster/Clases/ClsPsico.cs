using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using HerenciaMaster.Clases;

namespace HerenciaMaster.Clases
{
   public class ClsPsico
   {
       #region"Variables y propiedades"
       public string codigo;
       public string Nombres;
       public DateTime fe_nac;
       public int edad;
       public string est_civil;
       public string conyuge;
       public int hijos;
       public string grado_instru;
       public string domicilio;
       public string telf_fijo;
       public string telf_cel;
       public int ministerio; // busq en otra tabla
       public int pastor; // busq en otra tabla
       public string cursos_eclesiasticos;
       public string pruebas_psicom;
       public string motivo_entrev;
       public string antec_familiar;
       public string problemat_actual;
       public string analisis_clinico;
       public string resultados;
       public int estado;

        public int band = 0; // Registros grabados
       #endregion

        #region"****** Metodos *************"

  public void ExecuteSqlTransaction(string SqlProcedure,int opc)
        {
            ClsConexion cone = new ClsConexion();
            cone.Conect();
            using (SqlConnection connection = new SqlConnection(cone.Laconexion))
            {
                if (connection.State== ConnectionState.Closed) { connection.Open(); }
                SqlCommand cmd = new SqlCommand(SqlProcedure, connection); SqlTransaction transaction;
                transaction = connection.BeginTransaction("Transaction_"+SqlProcedure);
                cmd.Connection = connection;    cmd.Transaction = transaction;
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@opc", Convert.ToInt32(opc)); // opcion segun el proceso
                    cmd.Parameters.AddWithValue("@codigo", Convert.ToString(codigo));// lo lee de un sp
                    cmd.Parameters.AddWithValue("@Nombres", Convert.ToString(Nombres));
                    cmd.Parameters.AddWithValue("@fe_nac", Convert.ToDateTime(fe_nac));// 
                    cmd.Parameters.AddWithValue("@edad", Convert.ToInt32(edad));// 
                    cmd.Parameters.AddWithValue("@est_civil", Convert.ToString(est_civil)); //
                    cmd.Parameters.AddWithValue("@conyuge", Convert.ToString(conyuge));
                    cmd.Parameters.AddWithValue("@hijos", Convert.ToInt32(hijos));
                    cmd.Parameters.AddWithValue("@grado_instru", Convert.ToString(grado_instru));
                    cmd.Parameters.AddWithValue("@domicilio", Convert.ToString(domicilio));
                    cmd.Parameters.AddWithValue("@telf_fijo", Convert.ToString(telf_fijo));
                    cmd.Parameters.AddWithValue("@telf_cel", Convert.ToString(telf_cel));
                    cmd.Parameters.AddWithValue("@ministerio", Convert.ToString(ministerio));
                    cmd.Parameters.AddWithValue("@pastor", Convert.ToString(pastor));
                    cmd.Parameters.AddWithValue("@cursos_eclesiasticos", Convert.ToString(cursos_eclesiasticos));
                    cmd.Parameters.AddWithValue("@pruebas_psicom", Convert.ToString(pruebas_psicom));
                    cmd.Parameters.AddWithValue("@motivo_entrev", Convert.ToString(motivo_entrev));
                    cmd.Parameters.AddWithValue("@antec_familiar", Convert.ToString(antec_familiar));
                    cmd.Parameters.AddWithValue("@problemat_actual", Convert.ToString(problemat_actual));
                    cmd.Parameters.AddWithValue("@analisis_clinico", Convert.ToString(analisis_clinico));
                    cmd.Parameters.AddWithValue("@resultados", Convert.ToString(resultados));
                    cmd.Parameters.AddWithValue("@estado", Convert.ToInt32(estado));   //estado
                  
                    cmd.ExecuteNonQuery();

                    //Graba mi transaction.
                    transaction.Commit();
                    band = 1;// Console.WriteLine("hecho todo ok.");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);
                    band = 0;
                    // Attempt to roll back the transaction.
                    try
                    {
                        band = 0; transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        band = 0;
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
            }
        }

    }// fin de clase psico

        #endregion


      
}  // fin de  HerenciaMaster.Clases
