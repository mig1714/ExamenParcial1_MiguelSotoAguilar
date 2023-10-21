using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial1_MiguelSotoAguilar
{
    internal class ClsMenuReportes
    {


        public static void DesplegarReportes() 
        
        {

            int opcion = 0;
            ClsMenu menu = new ClsMenu();

            bool bandera = true;


            do
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Reportes");
                Console.WriteLine("1-Consultar por empleados por número de cédula");
                Console.WriteLine("2-Listar los empleados por órden alfabético");
                Console.WriteLine("3-Calcular el promedio de los salarios");
                Console.WriteLine("4-Mostrar el el salario más alto y el más bajo");
                Console.WriteLine("5-Salir");
                Console.WriteLine("");
                Console.WriteLine("");
                int.TryParse(Console.ReadLine(), out opcion);
                if (opcion == 5) 
                
                {

                    bandera = false;
                }

                switch (opcion) 
                {
                    case 1: ClsEmpleado.ConsultarEmpleado();break;
                    case 2: Console.WriteLine( ClsEmpleado.MostrarEnOrden(ClsEmpleado.nombres)); break;
                    case 3: Console.WriteLine("Promedio de Salarios: "+ ClsEmpleado.PromedioSalarios(ClsEmpleado.salarios)); break;
                    case 4: Console.WriteLine(ClsEmpleado.SalarioMaxMin(ClsEmpleado.salarios)); break;
                    case 5:  break;
                
                }
                
    


        } while (bandera);



        }
        
    }
}
