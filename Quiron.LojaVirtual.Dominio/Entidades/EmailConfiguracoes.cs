using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiron.LojaVirtual.Dominio.Entidades
{
    public class EmailConfiguracoes
    {
        //public bool UsarSsl { get; set; }
        public bool UsarSsl = false;

        //public string ServidorSmtp { get; set; }
        public string ServidorSmtp = "smtp.quiron.com.br";

        //public int ServidorPorta { get; set; }
        public int ServidorPorta = 587;

        //public string Usuario { get; set; }
        public string Usuario = "Quiron";

        //public bool EscreverArquivo { get; set; }
        public bool EscreverArquivo = false;

        //public string PastaArquivo { get; set; }
        public string PastaArquivo = @"c:\envioemail";

        //public string De { get; set; }
        public string De = "quiron@quiton.com.br";

        //public string Para { get; set; }
        public string Para = "pedido@quiron.com.br";
    }
}
