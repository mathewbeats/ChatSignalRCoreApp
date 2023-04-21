using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatSignalIr.Controllers
{
    public class ChatsController : Controller
    {
        public static Dictionary<int, string> ListaChats = new Dictionary<int, string>()
        {
            {1, "Tecnologia" },
            {2, "Deporte" },
            {3, "Noticias" }
        };

        public IActionResult ListaDeChats()
        {
            return View(ListaChats);
        }

        public IActionResult Chat(int idChat)
        {
            return View("Chat", idChat);
        }
    }
}
