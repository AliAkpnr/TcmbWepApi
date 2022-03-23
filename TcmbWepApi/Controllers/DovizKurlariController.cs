using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace TcmbWepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DovizKurlariController : ControllerBase
    {
        String url = "https://www.tcmb.gov.tr/kurlar/today.xml";

        [HttpGet("today")]
        public IActionResult Today()
        {
            var httpClient = new HttpClient();
            var result = httpClient.GetAsync(url).Result;

            var stream = result.Content.ReadAsStreamAsync().Result;
            
            var itemXml = XElement.Load(stream); 
            Tarih_Date tarih_Date;
            XmlSerializer serializer = new XmlSerializer(typeof(Tarih_Date));
            using (TextReader reader = new StringReader(itemXml.ToString()))
            {
                tarih_Date = (Tarih_Date)serializer.Deserialize(reader);
            }
           
           

            return Ok(tarih_Date);
        }
    }
}
