using JGApiNasaVMsv.JGModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JGApiNasaVMsv.JGModels;

namespace JGApiNasaVMsv.JGServices
{
    public class JGApodService
    {
        public async Task<JGApod> GetImage(DateTime dt)
        {
            JGApod dto = null;
            HttpResponseMessage response;
            string requestUrl = $"https://api.nasa.gov/planetary/apod?date={dt.ToString("yyyy-MM-dd")}&api_key=oDxOPQL655sCxjapH1mGLOfQFTWuCnrOSYEDZW3G"; 
            try 
            { 
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, requestUrl); 
                HttpClient client = new HttpClient(); 
                response = await client.SendAsync(request); 
                if (response.StatusCode == System.Net.HttpStatusCode.OK) 
                { 
                    string json = await response.Content.ReadAsStringAsync(); 
                    dto = JsonConvert.DeserializeObject<JGApod>(json); 
                } 
            } 
            catch (Exception ex) 
            { 
                string message = ex.Message; 
                throw; 
            } 
            return dto; 
        }
    }
}