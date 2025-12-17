using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using HerenciaMaster.Clases;
using System.Configuration;
using System.IO;

namespace HerenciaMaster.Clases
{
    public class ClsConexion
    {
        public String Laconexion = "";
        public void Conect()
        {
     
            Laconexion = "Data Source=192.168.25.3;Initial Catalog=PSICOLOGA;Persist Security Info=True;User ID=sa;Password=Sysadm23577";
        //    Laconexion = "http://sistema.ccgye.org/appweb/home.aspx/Web.config";
                
                
            
        }
       

    }
}
