using Practica03WS.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Practica03WS
{
    /// <summary>
    /// Descripción breve de CalcularWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcularWebService : System.Web.Services.WebService
    {
        private Calcular Areas = new Calcular();
        [WebMethod]
        public double Cuadrado(int B)
        {
           
            return Areas.Cuadrado(B);
        }

        [WebMethod]
        public double AreaTriangulo(int T, int O)
        {
           
            return Areas.Triangulo(T, O);
        }

        [WebMethod]
        public double AreaCirculo(int C)
        {
         
            return Areas.Circulo(C);
        }

    }
}
