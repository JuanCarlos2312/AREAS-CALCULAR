using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServicioWeb_Calculo
{
    /// <summary>
    /// Descripción breve de WebServiceArea
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceArea : System.Web.Services.WebService
    {

        [WebMethod]
        public string Estudiante()
        {
            return "Juan Carlos Espinosa Leon";
        }
        [WebMethod]
        public int CUADRADO(int LADO)
        {
            return LADO * LADO;
        }
        [WebMethod]
        public int TRIANGULO(int BASE, int ALTURA)
        {
            return BASE * ALTURA / 2;
        }

        [WebMethod]
        public double CIRCULO(double RADIO)
        {
            return 3.1416 * RADIO * RADIO;
        }
    }
}
