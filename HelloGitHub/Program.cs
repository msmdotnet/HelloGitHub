using System.Text;

namespace HelloGitHub
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", (HttpResponse response) =>
            {
                string Message = @"
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css"" 
rel=""stylesheet"" integrity=""sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65"" 
crossorigin=""anonymous"">

<p class=""container alert alert-info mt-5"">
Este código fue diseñado para ejemplificar el despliegue de <b><i>Azure App Service Web App</i></b> 
desde un repositorio de GitHub.</p>
";
                response.ContentType= "text/html; charset=utf-8";
                response.Body.Write(Encoding.UTF8.GetBytes(Message));
                response.StatusCode = 200;                
            });

            app.Run();
        }
    }
}