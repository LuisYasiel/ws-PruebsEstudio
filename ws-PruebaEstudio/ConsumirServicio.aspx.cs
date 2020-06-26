using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ws_PruebaEstudio
{
    public partial class ConsumirServicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonVerificar_Click(object sender, EventArgs e)
        {
            ServiceReference1.PruebaEstudioSoapClient aux = new ServiceReference1.PruebaEstudioSoapClient();
            if (aux.VerificarCuenta(TextBoxUsuario.Text, TexboBoxContrasenna.Text))
            {
                LabelResultado.Text = ("Usuario y contrasenna correctos");
            }
            else 
            {
                LabelResultado.Text = ("Usuario y contrasenna incorrectos");
            }
        }
    }
}