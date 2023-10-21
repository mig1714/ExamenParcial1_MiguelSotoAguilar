using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExamenParcial1_MiguelSotoAguilar
{
    internal class ClsEmpleado
    {
        string cedula;
        string nombre;
        string direccion;
        string telefono;
        static float salario;
        static int cantidad = 0;

        static public string[] cedulas = new string[cantidad];
        static public string[] nombres = new string[cantidad];
        static string[] direcciones = new string[cantidad];
        static string[] telefonos = new string[cantidad];
        public static float[] salarios = new float[cantidad];


        public static void InicializarArreglos()
        {
            Console.WriteLine("Ingrese la cantidad de empleados");
            int.TryParse(Console.ReadLine(), out cantidad);

            cedulas = Enumerable.Repeat("", cantidad).ToArray();
            nombres = Enumerable.Repeat("", cantidad).ToArray();
            direcciones = Enumerable.Repeat("", cantidad).ToArray();
            telefonos = Enumerable.Repeat("", cantidad).ToArray();
            salarios = Enumerable.Repeat(0f, cantidad).ToArray();
        }

        public static void AgregarEmpleado()

        {
            int posicion = 0;
            string opcionEmpleado = "";
            bool bandera = false;


            do
            {
                Console.WriteLine("Ingreso de empleado digite 'S' para si o 'N' para no");
                opcionEmpleado = Console.ReadLine().ToLower();


                if (opcionEmpleado.Equals("s"))
                {
                    for (int i = 0; i < cedulas.Length; i++)
                    {

                        if (cedulas[i].Equals(""))

                        {

                            bandera = true;

                            Console.WriteLine("Digite la cédula");
                            cedulas[i] = Console.ReadLine();

                            Console.WriteLine("Digite el Nombre");
                            nombres[i] = Console.ReadLine();

                            Console.WriteLine("Digite la dirección");
                            direcciones[i] = Console.ReadLine();

                            Console.WriteLine("Digite el teléfono");
                            telefonos[i] = Console.ReadLine();

                            Console.WriteLine("Digite el salario");
                            float.TryParse(Console.ReadLine(), out salario);
                            salarios[i] = salario;

                            break;



                        }


                    }





                }
                else
                {

                    bandera = false;
                }





            } while (bandera);

            ClsMenu menu = new ClsMenu();
            menu.Desplegar();


        }

        public static void ConsultarEmpleados()

        {
            int numeroEmpleado = 1;


            for (int i = 0; i < cedulas.Length; i++)


            {
                if (!cedulas[i].Equals(""))
                {

                    Console.WriteLine("*********************************Empleados************************************");
                    Console.WriteLine("Número Empleado: " + numeroEmpleado);
                    Console.WriteLine("Cédula: " + cedulas[i]);
                    Console.WriteLine("Nombre: " + nombres[i]);
                    Console.WriteLine("Dirección: " + direcciones[i]);
                    Console.WriteLine("Telefono: " + telefonos[i]);
                    Console.WriteLine("Salario: " + salarios[i]);
                    Console.WriteLine("******************************************************************************");
                    numeroEmpleado++;


                }



            }
        }



        public static void ModificarEmpleado()
        {

            string consulta = "";
            string infoEmpleado = "";
            bool bandera = false;
            int opcionModificar = 0;

            string nuevaBusqueda = "";

            string nuevoNombre = "";



            string nuevaDireccion = "";
            string nuevoTelefono = "";

            float nuevoSalario = 0.0f;

            do
            {

                Console.WriteLine("Digite el número de cédula: ");
                consulta = Console.ReadLine();
                

                      




                for (int i = 0; i < cedulas.Length; i++)


                {
                    if (cedulas[i].Equals(consulta))
                    {
                        Console.WriteLine(cedulas[i].Equals(consulta));
                        



                        infoEmpleado = "Cédula: " + cedulas[i];
                        infoEmpleado = "Nombre: " + nombres[i];
                        infoEmpleado += "\nDirección: " + direcciones[i];
                        infoEmpleado += "\nTeléfono: " + telefonos[i];
                        infoEmpleado += "\nSalario: " + salarios[i];

                        Console.WriteLine(infoEmpleado);



                        do
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Menú Modificar");
                            Console.WriteLine("1-Nombre");
                            Console.WriteLine("2-Dirección");
                            Console.WriteLine("3-Teléfono");
                            Console.WriteLine("4-Salario");
                            Console.WriteLine("5-Todos los valores");
                            Console.WriteLine("6-Salir");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            int.TryParse(Console.ReadLine(), out opcionModificar);
                            if (opcionModificar == 6)
                            {
                                bandera = false;
                                break;
                            }

                            if (opcionModificar == 1)
                            {
                                Console.WriteLine("Ingrese el nombre: ");
                                nuevoNombre = Console.ReadLine();
                                nombres[i] = nuevoNombre;
                                break;

                            }
                            else if (opcionModificar == 2)
                            {
                                Console.WriteLine("Ingrese la dirección: ");
                                nuevaDireccion = Console.ReadLine();
                                direcciones[i] = nuevaDireccion;
                                break;

                            }

                            else if (opcionModificar == 3)
                            {
                                Console.WriteLine("Ingrese el teléfono: ");
                                nuevoTelefono = Console.ReadLine();
                                telefonos[i] = nuevoTelefono;
                                break;

                            }

                            else if (opcionModificar == 4)
                            {
                                Console.WriteLine("Ingrese el salario: ");
                                float.TryParse(Console.ReadLine(), out nuevoSalario);
                                salarios[i] = nuevoSalario;
                                break;

                            }
                            else if (opcionModificar == 5)
                            {
                                Console.WriteLine("Ingrese el nombre: ");
                                nuevoNombre = Console.ReadLine();
                                nombres[i] = nuevoNombre;

                                Console.WriteLine("Ingrese la dirección: ");
                                nuevaDireccion = Console.ReadLine();
                                direcciones[i] = nuevaDireccion;


                                Console.WriteLine("Ingrese el teléfono: ");
                                nuevaDireccion = Console.ReadLine();
                                telefonos[i] = nuevoTelefono;


                                Console.WriteLine("Ingrese el salario: ");
                                float.TryParse(Console.ReadLine(), out nuevoSalario);
                                salarios[i] = nuevoSalario;

                                break;



                            }

                            else
                            {

                                {


                                    Console.WriteLine("Desea realizar otra búsqueda 'S' para si o 'N' para no");
                                    nuevaBusqueda = Console.ReadLine().ToLower();

                                    if (nuevaBusqueda.Equals("s"))
                                    {
                                        bandera = true;


                                    }
                                    else
                                    {

                                        Console.WriteLine("Fin de la búsqueda");
                                        bandera = false;
                                        break;
                                    }
                                }










                            } 
                        } while (opcionModificar != 6);

                    }

                }

            } while (bandera);

        }
    

        public static void ConsultarEmpleado()
        {

            string consulta = "";
            bool bandera = false;
            string opcionConsulta = "";

            do
            {

                Console.WriteLine("Digite el número de cédula: ");
                consulta = Console.ReadLine();

                Console.WriteLine("Cedula en reporte consulta empleado: "+consulta);

                for (int i = 0; i < cedulas.Length; i++)
                {
                    if (cedulas[i].Equals(consulta))
                    {





                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("*********************************Empleados************************************");
                        Console.WriteLine("Cédula: " + cedulas[i]);
                        Console.WriteLine("Nombre: " + nombres[i]);
                        Console.WriteLine("Dirección: " + direcciones[i]);
                        Console.WriteLine("Telefono: " + telefonos[i]);
                        Console.WriteLine("Salario: " + salarios[i]);
                        Console.WriteLine("*******************************************************************************");
                        Console.WriteLine("");
                        Console.WriteLine("");







                    }
                    else
                    {

                        Console.WriteLine("Desea realizar otra consulta digite 'S' para si o 'N' para no");
                        opcionConsulta = Console.ReadLine().ToLower();

                        if (opcionConsulta.Equals("s"))
                        {

                            bandera = true;
                        }
                        else
                        {
                            bandera = false;
                        }




                    }





                }


            } while (bandera);


        }


        public static void BorrarEmpleado() 
        {

            string consulta = "";
            bool bandera = false;
            string opcionConsulta = "";

            do
            {

                Console.WriteLine("Digite el número de cédula: ");
                consulta = Console.ReadLine();

                for (int i = 0; i < cedulas.Length; i++)
                {
                    if (cedulas[i].Equals(consulta))
                    {
                        Console.WriteLine("Registro borrado");
                        cedulas[i] = "";
                        nombres[i] = "";
                        direcciones[i] = "";
                        telefonos[i] = "";
                        salarios[i] = 0.0f;





                    }
                    else
                    {

                        Console.WriteLine("Ingreso de empleado digite 'S' para si o 'N' para no");
                        opcionConsulta = Console.ReadLine().ToLower();

                        if (opcionConsulta.Equals("s"))
                        {

                            bandera = true;
                        }
                        else
                        {
                            bandera = false;
                        }




                    }





                }


            } while (bandera);



        }


        public static string MostrarEnOrden(string[] array) 
        {

            string resultado = "";
            Comparison<string> comparar = new Comparison<string>((cadena1, cadena2) => cadena1.CompareTo(cadena2));

            Array.Sort<string>(array, comparar);
            foreach (string str in array ) 
            {

                resultado += "Nombre: "+str + "\n";
            }

            

            return resultado; 

            
        
        
        }

        public static float PromedioSalarios(float[] array) 
        {

            float resultado = 0.0f;

            resultado = array.Average();

            return resultado;
        
        }

        public static string SalarioMaxMin(float[] array) 
        {
            float max = 0.0f;
            float min = 0.0f;

            max = array.Max();
            min = array.Min();
            string msj1 = "Salario máximo: ";
            string msj2 = "Salario mínimo: ";
            return  msj1 + max +"\n"+ msj2  + min;
        
        }


    }

    
}
