using System.IO;
using System.Net;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace ApiTienda.Controllers.Concrete
{
    public class ImageController : ApiController
    {
   
        [HttpPost]
        public IHttpActionResult Post()
        {
            var httpRequest = HttpContext.Current.Request;
            var name = httpRequest["Nombre"];
            bool finish = false;
            foreach (string file in httpRequest.Files)
            {
                var postedFile = httpRequest.Files[file];
                if (postedFile != null && postedFile.ContentLength > 0)
                {
                    string ruta = HttpContext.Current.Server.MapPath(@"~/Content/Images/" + name);
                       
                    postedFile.SaveAs(ruta);
                    finish = true;
                }
            }
            return Ok(finish);
        }
        public IHttpActionResult Delete()
        {
            var httpRequest = HttpContext.Current.Request;
            var Image = httpRequest["Image"];
            if (File.Exists(HttpContext.Current.Server.MapPath(@"~/Content/Images/" + Image)))
            {
                File.Delete(Image);
            }
            return Ok(""); 
        }
        [HttpPut]
        public IHttpActionResult Put()
        {
            var httpRequest = HttpContext.Current.Request;
            var newImage = httpRequest["newImage"];
            var oldImage = httpRequest["oldImage"];
       
            if (File.Exists(HttpContext.Current.Server.MapPath(@"~/Content/Images/" + oldImage)))
            {
                File.Delete(oldImage);
            }
            bool finish = false;
            foreach (string file in httpRequest.Files)
            {
                var postedFile = httpRequest.Files[file];
                if (postedFile != null && postedFile.ContentLength > 0)
                {
                    postedFile.SaveAs(HttpContext.Current.Server.MapPath(@"~/Content/Images/" + newImage));
                    finish = true;
                }
            }
            return Ok(finish);
        }

        [HttpGet]
        public IHttpActionResult GetThumbnail(string image)
        {
            string formato = Path.GetExtension(image);
            string imagen = Path.GetFileNameWithoutExtension(image);
            string directorio = HttpContext.Current.Server.MapPath(@"~/Content/Images/" + imagen + formato);
            var stream = File.OpenRead(HttpContext.Current.Server.MapPath(@"~/Content/Images/image_not_found.jpg"));
            if (File.Exists(directorio))
            {
                stream = File.OpenRead(directorio);
            }
            var response = new System.Net.Http.HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new System.Net.Http.StreamContent(stream);

            response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/jpg");
            response.Content.Headers.ContentLength = stream.Length;

            return ResponseMessage(response);
        }




    }
}

