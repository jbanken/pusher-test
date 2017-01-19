
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using PusherServer;
using PusherTest.Models;

namespace PusherTest.Controllers
{
    public class PushController : Controller
    {
        [ValidateInput(false)]
        public ContentResult Send([FromBody]PushSend request)
        {
            var options = new PusherOptions();
            options.Cluster = "eu";
            options.Encrypted = true;
            var pusher = new Pusher("291363", "48021ed1b96971d522e7", "663be45a23c99fdc4dd0", options);

            var result = pusher.Trigger(request.Channel, "Event:Listen", new { message = request.Message });

            return Content(result.ToString(), "application/json");
        }

    }
}
