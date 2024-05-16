namespace Proyecto_Hotel.Models
{
    public class CedulaAPI
    {
        public HttpClient Iniciar()
        {
            var client = new HttpClient();

            client.BaseAddress = new Uri("https://apis.gometa.org");

            return client;
        
        
        }//

    }//
}
