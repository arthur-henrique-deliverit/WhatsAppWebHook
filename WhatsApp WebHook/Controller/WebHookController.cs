using Microsoft.AspNetCore.Mvc;
using WhatsApp_WebHook.Service;

namespace WhatsApp_WebHook.Controller
{
    [ApiController, Route("")]
    public class WebHookController : ControllerBase
    {
        private readonly ILogger<WebHookController> logger;
        private readonly IWebHookService webHookService;

        public WebHookController(ILogger<WebHookController> logger, IWebHookService webHookService)
        {
            this.logger = logger;
            this.webHookService = webHookService;
        }

        [HttpGet("webhook")]
        public string SetupWebHook([FromQuery(Name = "hub_mode")] string hubMode,
                                          [FromQuery(Name = "hub_challenge")] string hubChallenge,
                                          [FromQuery(Name = "hub_verify_token")] string hubVerifyToken)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
            return hubChallenge;
        } 
    }
}
