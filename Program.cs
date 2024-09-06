using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static List<cls_personas> persons = new List<cls_personas>();
        static void Main(string[] args)
        {
            fnt_menu(true);
        }
        private static void fnt_menu(Boolean men)
        {
            while (men == true)
            {
                Console.Clear();
                Console.Write("<<<< MENÚ PRINCIPAL >>>> \n\n 1. AGREGAR \n 2. CONSULTAR \n 3. SALIR \n ->");
                string var_opcionStr = Console.ReadLine();
                if (var_opcionStr.Equals("1"))
                {
                    fnt_capturar();

                }

                if (var_opcionStr.Equals("2"))
                {
                    Console.Clear();
                    Console.Write("<<<< MODÚLO DE CONSULTA >>>> \n");
                    Console.Write("\n Ingrese la identificación de la persona a consultar:   ");
                    string id = Console.ReadLine();
                    fnt_consulta(id);

                }

                if (var_opcionStr.Equals("3"))
                {
                    men = false;
                }
            }
        }
        private static void fnt_capturar()
        {
            Console.Clear();
            Console.Write("<<<<< INGRESO DE PERSONAS >>>>>\n");
            Console.Write("\nIngrese su nombre completo:  ");
            string name = Console.ReadLine().ToUpper();
            Console.Write("Ingrese su identificación:  ");
            string id = Console.ReadLine();
            Console.Write("Ingrese su edad:  ");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.Write("Ingrese  su número de contacto:  ");
            string contact = Console.ReadLine();
            fnt_agregar(name, id, age, contact);
        }
    
        private static void fnt_agregar(string name, string id, int age, string contact)
        {
            persons.Add(new cls_personas(name, id, age, contact));
            Console.Write("\n LA PERSONA " + name + "HA SIDO ALMACENADA CON ÉXITO <ENTER>");
            Console.ReadLine();
    }

        private static void fnt_consulta(string id)
        {
            Boolean var_swbln = false;
            int var_posicionInt = 0;
            for (int i = 0; i < persons.Count; i++)
            {
                if (id.Equals(persons[i].getIdStr()))
                {
                    var_swbln = true;
                    var_posicionInt = i;
                    break;
                }

            }
            if (var_swbln == false)
            {
                Console.Write("\n EL ID" + id + "NO SE ENCUENTRA REGISTRADO <ENTER>");
                Console.ReadLine();
            }
            else
            {
                Console.Write("\n Nombres: ...." + persons[var_posicionInt].getNombreStr());
                Console.Write("\n Edad: ...." + persons[var_posicionInt].getEdadInt());
                Console.Write("\n Contacto: ...." + persons[var_posicionInt].getContactoStr());
                Console.ReadLine();
            }
            

        }
    }
 }
