using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Newtonsoft.Json;

namespace Controller
{
    [ApiController]
    [Route("dlr")]
    public class DeliveryReportController : ControllerBase
    {
        [HttpPost("save-json")]
        public async Task< ActionResult<string>> SaveJson()
        {
            string json = await new StreamReader(Request.Body).ReadToEndAsync();
            var obj = JsonConvert.DeserializeObject<DeliveryReport>(json);

            // TODO: you may use the 'obj' data like saving it to database, write it to log
            // as you wish

            return $"SUCCESS. Value received:\n\nFrom: {obj.From}\nTo: {obj.To}\nStatus: {obj.Status}\nErrCode: {obj.ErrorCode}\nMsgId: {obj.MsgId}";
        }
    }
}