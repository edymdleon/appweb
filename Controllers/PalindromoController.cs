using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VWorkS.Controllers
{
    public class PalindromoController : Controller
    {
        public IActionResult Index(string Busqueda)
        {
            var lista = palindrome(Busqueda);
            ViewBag.Cantidad = lista.Count;
            ViewBag.Lista = lista;
            return View();
        }

        public List<string> palindrome(string dato)
        {
            List<string> result = new List<string>();
            if (dato != null)
            {
                string[] cadena = dato.Split(' ');
                foreach (var valor in cadena)
                {
                    if (getStatus(valor))
                    {
                        result.Add(valor);
                    }

                }
            }
            return result;
        }
        public static bool getStatus(string dato)
        {
            string first = dato.Substring(0, dato.Length / 2);
            char[] arr = dato.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }

    }
}
