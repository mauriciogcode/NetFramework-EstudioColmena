using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioColmenaTrabajoPractico.Modelo
{
    class SistemSoportEmail : ServidorEmailMaestro
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

