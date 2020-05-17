using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool continuarActivo = true;
            
            string menu = "0) Encender Maquina \n1) Latas Disponibles \n2) Ingresar Lata " +
                "\n3) Extraer Lata \n4) Obtener Balance \n5) Mostrar Stock \nX) Salir";
            
            Expendedora exp = new Expendedora("Expendedora 1");

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

        /*
        #region "Métodos Propios de este programa, no reutilizables ya que piden ingresos solo para interfaz consola"
        private static void EliminarEmpleado(Facultad fce)
        {
            try
            {
                Console.WriteLine("Seleccione el legajo de empleado a eliminar: ");
                int leg = int.Parse(Console.ReadLine());
                List<int> lst = new List<int>();
                foreach (Empleado e in fce.Empleados)
                {
                    lst.Add(e.Legajo);
                }

                if (!lst.Contains(leg))
                {
                    Console.WriteLine("El empleado no pertenece a la facultad.");
                }
                else
                {
                    fce.EliminarEmpleado(leg);
                }

            }
            catch
            {

            }
        }

        private static void AgregarEmpleado(Facultad facultad)
        {
            try
            {

                string n = ConsolaHelper.PedirString("Nombre");
                string a = ConsolaHelper.PedirString("Apellido");
                int c = ConsolaHelper.PedirInt("Legajo");
                string t = ConsolaHelper.PedirString("tipo empleado (D docente, B bedel, A directivo)");
                DateTime f = ConsolaHelper.PedirFecha("Ingreso laboral");
                double s = ConsolaHelper.PedirDouble("Salario Bruto");

                string ap = string.Empty;
                if (t.ToUpper() == "B")
                {
                    ap = ConsolaHelper.PedirString("Apodo");
                }

                string mat = string.Empty;
                if (t.ToUpper() == "D")
                {
                    mat = ConsolaHelper.PedirString("Materia");
                }

                // acá si necesitamos enviarle los param al método para que sepa que tipo de obj crear
                facultad.AgregarEmpleado(n, a, c, f, t, ap, s, mat);
                Console.WriteLine("Empleado agregado.");

            }
            catch (Exception ex)
            {
                // podemos usar recursión para que no salga del método hasta que no lo haga bien.
                Console.WriteLine("Error en uno de los datos ingresados. " + ex.Message + " Intente nuevamente. \n\n");

                // podemos preguntarle si quiere hacerlo de nuevo. Depende de nuestro negocio.
                // if(quiereIntentarNuevamente)
                AgregarEmpleado(facultad);
            }
        }

        private static void EliminarAlumno(Facultad fce)
        {

            try
            {
                Console.WriteLine("Seleccione el codigo de alumno a eliminar: ");
                int cod = int.Parse(Console.ReadLine());
                List<int> lst = new List<int>();
                foreach (Alumno a in fce.Alumnos)
                {
                    lst.Add(a.Codigo);
                }

                if (!lst.Contains(cod))
                {
                    Console.WriteLine("El alumno no pertenece a la facultad.");
                }
                else
                {
                    fce.EliminarAlumno(cod);
                }

            }
            catch
            {

            }

        }

        private static void AgregarAlumno(Facultad facultad)
        {
            try
            {
                string n = ConsolaHelper.PedirString("Nombre");
                string a = ConsolaHelper.PedirString("Apellido");
                int c = ConsolaHelper.PedirInt("Código");
                DateTime f = ConsolaHelper.PedirFecha("nacimiento");

                // opcion 1 generamos el objeto acá
                Alumno al = new Alumno(c, n, a, f);
                facultad.AgregarAlumno(al);
                Console.WriteLine("Alumno agregado.");
                // opción 2 mandamos valores y que lo genere el propio método
                // facultad.AgregarAlumno(n,a,c,f);
            }
            catch (Exception ex)
            {
                // podemos usar recursión para que no salga del método hasta que no lo haga bien.
                Console.WriteLine("Error en uno de los datos ingresados. " + ex.Message + " Intente nuevamente. \n\n");

                // podemos preguntarle si quiere hacerlo de nuevo. Depende de nuestro negocio.
                // if(quiereIntentarNuevamente)
                AgregarAlumno(facultad);
            }

        }

        public static void ListarAlumnos(Facultad facultad)
        {
            List<int> lst = new List<int>();
            foreach (Alumno a in facultad.Alumnos)
            {
                lst.Add(a.Codigo);
            }

            if (lst.Count == 0)
            {
                Console.WriteLine("No hay alumnos inscriptos.");
            }

            if (lst.Count > 0)
            {
                Console.WriteLine("Alumnos inscriptos: ");
            }

            foreach (Alumno a in facultad.Alumnos)
            {
                MostrarCredencial(a);
            }

            if (lst.Count > 0)
            {
                Console.WriteLine("\nTotal de inscriptos: " + lst.Count);
            }


        }

        public static void ListarEmpleados(Facultad facultad)
        {
            List<int> lst = new List<int>();

            foreach (Empleado e in facultad.Empleados)
            {


                if (e.Tipo.ToUpper() == "D")
                {

                    {
                        lst.Add(e.Legajo);
                    }

                    if (lst.Count > 0)
                    {
                        Console.WriteLine("Docente inscripto: ");
                    }


                    {
                        MostrarCredencial(e);
                    }


                    if (lst.Count > 0)
                    {
                        Console.WriteLine("\nTotal de docentes inscriptos: " + lst.Count + "\n");
                    }

                }
                else
                {

                    MostrarCredencial(e);

                }

            }
        }

        private static void MostrarCredencial(Persona persona)
        {
            Console.WriteLine(persona.GetCredencial());
        }

        #endregion

        */
    }
}
