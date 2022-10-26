using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Entidades.ServicioEmail
{
    public class SistemSoportEmail : ServidorEmailMaestro
    {
        public SistemSoportEmail()
        {
            senderMail = "lacolmenaSoft@gmail.com";
            password = "Analista1234";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpCliente();
        }


    }
}
