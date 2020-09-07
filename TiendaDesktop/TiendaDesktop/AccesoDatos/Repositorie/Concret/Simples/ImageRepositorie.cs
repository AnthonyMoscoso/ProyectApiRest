using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TiendaApp.Core.Utilities;

namespace TiendaDesktop.Infrastructure.Repositorie.Concret.Simples
{
    class ImageRepositorie
    {
        public async Task<string> Post( string name, byte[] file_bytes)
        {
            string actionUrl = UrlConexion.Host + "Image";
            HttpClient httpClient = new HttpClient();
            MultipartFormDataContent form = new MultipartFormDataContent();

            form.Add(new StringContent(name), "Nombre");
            form.Add(new ByteArrayContent(file_bytes, 0, file_bytes.Length), "profile_pic", "image.jpg");
            HttpResponseMessage response = await httpClient.PostAsync(actionUrl, form);
            response.EnsureSuccessStatusCode();
            httpClient.Dispose();
            string sd = response.Content.ReadAsStringAsync().Result;
            if (!response.IsSuccessStatusCode)
            {
                return "image_not_found.jpg";
            }
            else
            {
                await response.Content.ReadAsStreamAsync();
                return name;
            }

        }

        public async Task<string> Delete(string actionUrl, string name, byte[] file_bytes)
        {
            HttpClient httpClient = new HttpClient();
            MultipartFormDataContent form = new MultipartFormDataContent();

            form.Add(new StringContent(name), "Nombre");
            form.Add(new ByteArrayContent(file_bytes, 0, file_bytes.Length), "profile_pic", "image.jpg");
            HttpResponseMessage response = await httpClient.DeleteAsync(actionUrl);

            response.EnsureSuccessStatusCode();
            httpClient.Dispose();
            string sd = response.Content.ReadAsStringAsync().Result;
            if (!response.IsSuccessStatusCode)
            {
                return "image_not_found.jpg";
            }
            else
            {
                await response.Content.ReadAsStreamAsync();
                return name;
            }

        }
        public async Task<string> Put(string actionUrl, string oldImage, string newImage, byte[] file_bytes)
        {
            HttpClient httpClient = new HttpClient();
            MultipartFormDataContent form = new MultipartFormDataContent();

            form.Add(new StringContent(newImage), "newImage");
            form.Add(new StringContent(oldImage), "oldImage");
            form.Add(new ByteArrayContent(file_bytes, 0, file_bytes.Length), "profile_pic", "image.jpg");
            HttpResponseMessage response = await httpClient.PutAsync(actionUrl, form);

            response.EnsureSuccessStatusCode();
            httpClient.Dispose();
            string sd = response.Content.ReadAsStringAsync().Result;
            if (!response.IsSuccessStatusCode)
            {
                return "image_not_found.jpg";
            }
            else
            {
                await response.Content.ReadAsStreamAsync();
                return newImage;
            }

        }
        public Image DownloadImage(string imageUrl)
        {
            Image image = null;

            try
            {
                
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(UrlConexion.Host + "Image?image=" + imageUrl);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;
                webRequest.ServicePoint.ConnectionLeaseTimeout = 5000;
                webRequest.ServicePoint.MaxIdleTime = 5000;

                using (WebResponse webResponse = webRequest.GetResponse())
                {

                    using (Stream stream = webResponse.GetResponseStream())
                    {
                        image = Image.FromStream(stream);
                    }
                }

                webRequest.ServicePoint.CloseConnectionGroup(webRequest.ConnectionGroupName);
                webRequest = null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);

            }


            return image;
        }
    }
}
