using ChatManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatManager.Controllers
{
    [OnlineUsers.UserAccess]
    public class ChatRoomController : Controller
    {
        // GET: ChatRoom
        public ActionResult Index()
        {
            Session["LastAction"] = "/Accounts/GroupEmail";
            return View();
        }
    }
}