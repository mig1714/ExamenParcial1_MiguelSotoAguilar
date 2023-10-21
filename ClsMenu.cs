using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial1_MiguelSotoAguilar
{
    internal class ClsMenu
    {

        public void Desplegar() 
        
        {

            
            int opcion = 0;
            do
            {
                Console.WriteLine("Digite: ");
                Console.WriteLine("1-Agregar empleados");
                Console.WriteLine("2-Consultar Empleados");
                Console.WriteLine("3-Modificar Empleados");
                Console.WriteLine("4-Borrar Empleados");
                Console.WriteLine("5-Inicializar Arreglos");
                Console.WriteLine("6-Reportes");
                Console.WriteLine("7-Salir");
                int.TryParse(Console.ReadLine(), out opcion);



                if (opcion == 7)
                {
                    break;
                }


                switch (opcion)
                {

                    case 1: ClsEmpleado.AgregarEmpleado(); break;

                    case 2: ClsEmpleado.ConsultarEmpleados(); break;
                    case 3: ClsEmpleado.ModificarEmpleado(); break;
                    case 4: ClsEmpleado.BorrarEmpleado(); break;
                    case 5: ClsEmpleado.InicializarArreglos(); break;
                    case 6: ClsMenuReportes.DesplegarReportes(); break;
                    default:
                        Console.WriteLine("Valor Erróneo.");
                        break;
                }


                



            } while (opcion != 7);
           
            

            

        }
    }
        
}
