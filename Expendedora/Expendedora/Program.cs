
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solucion.LibreriaConsola;
using Solucion.LibreriaNegocio;


namespace Solucion.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool continuarActivo = true;
            
            string menu = "0) Encender Maquina \n1) Latas Disponibles \n2) Ingresar Lata " +
                "\n3) Extraer Lata \n4) Obtener Balance \n5) Mostrar Stock \nX) Salir";
            
            Expendedora exp = new Expendedora("Expetech",40,0,false);

            do
            {
                Console.WriteLine(menu); 

                try
                {
                    string opcionSeleccionada = Console.ReadLine();


                    if (ConsolaHelper.EsOpcionValida(opcionSeleccionada, "012345X"))
                    {
                        if (opcionSeleccionada.ToUpper() == "X")
                        {
                            continuarActivo = false;
                            continue;
                        }

                        switch (opcionSeleccionada)
                        {
                            case "0":
                                Program.EncenderMaquina(exp);
                                break;

                            case "1":
                                Program.ListarLatas(exp);
                                break;

                            case "2":
                                Program.IngresarLata(exp);
                                break;

                            case "3":
                                Program.ExtraerLata(exp);
                                break;

                            case "4":
                                Program.ObtenerBalance(exp);
                                break;

                            case "5":
                                Program.MostrarStock(exp);
                                break;

                            default:
                                Console.WriteLine("Opción inválida.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error durante la ejecución del comando. Por favor intente nuevamente. Mensaje: " + ex.Message);
                }
                Console.WriteLine("Ingrese una tecla para continuar.");

                Console.ReadKey();
                Console.Clear();
            }
            while (continuarActivo);

            Console.ReadKey();
        }


        #region 

        private static void EncenderMaquina(Expendedora exp)
        {

            exp.encenderMaquina();
            Console.WriteLine("La maquina ha sido encendida");


        }
        
        private static void ListarLatas(Expendedora exp)
        {
            Console.WriteLine("CO1 - Coca Cola Regular \nCO2 - Coca Cola Zero     \nSP1 - Sprite Regular" +
                                "\nSP2 - Sprite Zero  \nFA1 - Fanta Regular    \nFA2 - Fanta Zero");
        }

        private static void IngresarLata(Expendedora exp)
        {
            try
            {
                if (exp.Encendida == true)
                {
                    Console.WriteLine("Codigos validos: ");

                    foreach (String cod in exp.CodigosValidos())
                    {
                        Console.WriteLine(cod);
                    }


                    string c = ConsolaHelper.PedirString("Codigo");
                    if (ConsolaHelper.EsCodigoValido(c))
                    {



                        double p = ConsolaHelper.PedirDouble("Precio");
                        double v = ConsolaHelper.PedirDouble("Volumen");

                        string n = null;

                        if (c.ToUpper() == "CO1" || c.ToUpper() == "CO2")
                        {
                            n = "Coca Cola";
                        }
                        if (c.ToUpper() == "SP1" || c.ToUpper() == "SP2")
                        {
                            n = "Sprite";
                        }
                        if (c.ToUpper() == "FA1" || c.ToUpper() == "FA2")
                        {
                            n = "Fanta";
                        }

                        string r = null;

                        if (c.ToUpper() == "CO1" || c.ToUpper() == "SP1" || c.ToUpper() == "FA1")
                        {
                            r = "Regular";
                        }
                        if (c.ToUpper() == "CO2" || c.ToUpper() == "SP2" || c.ToUpper() == "FA2")
                        {
                            r = "Sprite";
                        }


                        Lata l = new Lata(c, n, r, p, v);
                        exp.agregarLata(l);
                        Console.WriteLine("Lata agregada.");

                    } else
                    {
                        Console.WriteLine("Codigo invalido. Intente nuevamente. \n\n");
                    }



                }
                else
                {
                    Console.WriteLine("Encienda la maquina");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en uno de los datos ingresados. " + ex.Message + " Intente nuevamente. \n\n");
            }
        }

        private static void ExtraerLata(Expendedora exp)
        {
        }

        private static void ObtenerBalance(Expendedora exp)
        {
            if (exp.Encendida == true)
            {
                Console.WriteLine (exp.getBalance());
            }
            else
            {
                Console.WriteLine("Encienda la maquina");
            }

        }

        private static void MostrarStock(Expendedora exp)
        {
            if (exp.Encendida == true)
            {
                if (exp.estaVacia() == false)
                {
                    foreach (Lata l in exp.Latas)
                    {
                        Console.WriteLine(l.Descripcion());

                    }

                } else
                {
                    Console.WriteLine("Maquina vacia");
                }
                
            }
            else
            {
                Console.WriteLine("Encienda la maquina");
            }
        }

       

        #endregion


    }
}
