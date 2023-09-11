using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TP4.EF.Entities;
using Newtonsoft.Json;

namespace TP4.EF.Logic
{
    public class BreakingBadAPILogic
    {
        public async Task<List<BreakingBadAPI>> getBreakingBad()
        {
            try
            {
                var httpClient = new HttpClient();
                string json = await httpClient.GetStringAsync("https://breakingbadapi.com/api/characters");
                List<BreakingBadAPI> breakingBad = JsonConvert.DeserializeObject<List<BreakingBadAPI>>(json);
                return breakingBad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
