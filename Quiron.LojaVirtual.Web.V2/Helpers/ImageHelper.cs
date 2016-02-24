using System.Configuration;

namespace Quiron.LojaVirtual.Web.V2.Helpers
{
    public class ImageHelper
    {
        private static AppSettingsReader _app;

        public static string CaminhoImagem()
        {
            _app = new AppSettingsReader();
            return _app.GetValue("Imagem", typeof(string)).ToString();
        }
    }
}