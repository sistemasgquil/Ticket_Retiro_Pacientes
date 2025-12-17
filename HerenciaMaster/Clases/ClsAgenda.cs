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
    

    public class ClsAgenda
    {

#region"******* Variables *********"
    public int codigo;
    public int dia;
    public int mes;
    public int anio;
    public string hora_ini;
    public string hora_fin;
    public string evento;
    public string nivel;
    public int band;
    public int estado;
    public int opcion;
    public string nomDia;
    public int orden;
    public DateTime fecha;

    #endregion

        #region"************* Metodos ***********"

    public void ExecuteSqlTransaction(string SqlProcedure, int opc)
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
                    cmd.Parameters.AddWithValue("@codigo", Convert.ToInt32(codigo));// lo lee de un sp
                    cmd.Parameters.AddWithValue("@dia", Convert.ToInt32(dia));
                    cmd.Parameters.AddWithValue("@mes", Convert.ToInt32(mes));// 
                    cmd.Parameters.AddWithValue("@anio", Convert.ToInt32(anio));// 
                    cmd.Parameters.AddWithValue("@hora_ini", Convert.ToString(hora_ini)); //
                    cmd.Parameters.AddWithValue("@hora_fin", Convert.ToString(hora_fin));
                    cmd.Parameters.AddWithValue("@evento", Convert.ToString(evento));
                    cmd.Parameters.AddWithValue("@nivel", Convert.ToString(nivel));
                    cmd.Parameters.AddWithValue("@estado", Convert.ToInt32(estado));   //estado
                    cmd.Parameters.AddWithValue("@nomDia", Convert.ToString(nomDia)); // nombre del dia
                    cmd.Parameters.AddWithValue("@orden", Convert.ToInt32(orden));//orden en las consultas
                    cmd.Parameters.AddWithValue("@fecha", Convert.ToDateTime(fecha));//fecha del evento
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
    }// fin de ExecuteSqlTransaction
    
        #endregion

    } // fin de public class ClsAgenda
}// fin de HerenciaMaster.Clases
