using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using TiendaApp.Core.Utilities;

namespace TiendaApp.Src.CategorieDirectory.Services
{
     public class RestSend
    {
        public static string Send<T>(string url, T objectRequest, string method )
        {
            string result = "";
            try
            {
           


                JavaScriptSerializer js = new JavaScriptSerializer();

                //serializamos el objeto
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest);

                //peticion
                var uri = UrlConexion.Host + url;
                WebRequest request = WebRequest.Create(uri);
                //headers
                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8'";
          
         //       request.Timeout = 10000; //esto es opcional

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

            }
            catch (Exception e)
            {



                result = e.Message;

            }

            return result;
        }
        public static string Delete<T>(string url, string method="Delete")
        {
             ;
            string result = "";
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                //serializamos el objeto
                //peticion
                var uri = UrlConexion.Host + url;
                WebRequest request = WebRequest.Create(uri);
                //headers
                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8'";
                request.Timeout = 10000; //esto es opcional
                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
        public static string SendI<T>(string url, T objectRequest, string method)
        {
            string result = "";
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                //serializamos el objeto
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest);

                //peticion
                WebRequest request = WebRequest.Create(url);
                //headers
                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "multipart/form-data";

                //       request.Timeout = 10000; //esto es opcional

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

            }
            catch (Exception e)
            {



                result = e.Message;

            }

            return result;
        }


        
    }
}
