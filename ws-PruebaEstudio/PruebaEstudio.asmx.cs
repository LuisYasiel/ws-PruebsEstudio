using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ws_PruebaEstudio
{
    /// <summary>
    /// Descripción breve de PruebaEstudio
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class PruebaEstudio : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public bool RetornarAlumno() 
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
               
            }
           
        }
        [WebMethod]
        public bool VerificarCuenta(string a, string b) 
        {
            bool valor = true;
            if (a == "Juan" && b == "12345")
            {
                return valor;
            }
            else 
            {
                return valor = false;
            }
        }
    }
}
