using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial1_MiguelSotoAguilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ClsMenu menu = new ClsMenu();
            menu.Desplegar();
            ClsEmpleado e = new ClsEmpleado();
            Console.WriteLine( ClsEmpleado.cedulas.Length);
            
            Console.ReadLine();

        }
    }
}
