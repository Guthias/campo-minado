using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_Minado
{
    class Functions
    {
        public void centralizar(string texto)
        {
            Console.SetCursorPosition((Console.WindowWidth - texto.Length) / 2, Console.CursorTop);
            Console.WriteLine(texto);
        }
    }
}
