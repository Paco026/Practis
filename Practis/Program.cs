using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Practis

{

    internal class Program

    {

        //Francisco Javier Saravia Saravia -MM21047

        static void Main(string[] args)

        {

            List<string> librosDisp = new List<string>();

            List<string> LibrosPres = new List<string>();

            List<string> Usuarios = new List<string>();



            string dispon = "";

            string person = "";

            string pres = "";



            bool salir = false;

            int opc = 0;



            do

            {

                Console.WriteLine("===============MENU=====================");

                Console.WriteLine("1- Agregar usuario");

                Console.WriteLine("2- Agregar libro");

                Console.WriteLine("3- ver libros disponibles");

                Console.WriteLine("4- prestar libros");

                Console.WriteLine("5- libros prestados");

                Console.WriteLine("6- Salir");

                opc = int.Parse(Console.ReadLine());











                switch (opc)

                {

                    case 1:

                        Console.WriteLine("Ingrese el nombre para el nuevo usuario");

                        person = Console.ReadLine();

                        Usuarios.Add(person);

                        Console.WriteLine("Usuario Añadido con exito \n");

                        Console.WriteLine("Entrando como el usuario " + person);

                        Console.WriteLine("");

                        break;

                    case 2:

                        Console.WriteLine("Ingrese el nombre de el libro a ingresar");

                        dispon = Console.ReadLine();

                        librosDisp.Add(dispon);

                        Console.WriteLine("Libro añadido con exito");

                        Console.WriteLine();

                        break;

                    case 3:

                        foreach (string a in librosDisp)

                        {

                            Console.WriteLine(a);

                        }

                        Console.WriteLine();

                        break;

                    case 4:

                        Console.WriteLine("Ingrese el libro que desea prestar");

                        pres = Console.ReadLine();



                        if (librosDisp.Contains(pres))

                        {

                            LibrosPres.Add(pres);

                            librosDisp.Remove(pres);

                        }

                        else

                        {

                            Console.WriteLine("Ese Libro no existe");

                        }



                        Console.WriteLine();

                        break;

                    case 5:

                        foreach (string b in LibrosPres)

                        {

                            Console.WriteLine(b);

                        }

                        Console.WriteLine();

                        break;

                    case 6:

                        salir = true;

                        Console.WriteLine("Hasta pronto");

                        break;

                }

            } while (!salir);

        }

    }

    /*Para el ejercicio decidi usar 3 listas una que almacene los nombres, otra los libros , y una mas que almacena los libros que se prestaron

     * al momento de prestar un libro el nombre se busca en la lista de libros disponibles usando la funcion contains, si el libro esta entonces

     * este se remueve de dicha lista y se agrega a la lista de libros prestados , por tiempo no pude agregar mas opciones para el usuario sorry*/

}