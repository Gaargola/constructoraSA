using System;
namespace constructora
{
  public class Program
  {
    public static void Main(string[] args)
    {
      MenuInicial();
    }
    public static void MenuInicial()
    {
      TituloColor();
      Console.WriteLine("Bienvenido a la empresa constructora.");
      Console.WriteLine("---------> Menu principal <---------");
      DefaultColor();
      Console.WriteLine("1- Contratar un obrero nuevo (se agrega a la empresa y a un grupo)");
      Console.WriteLine("2- Eliminar un obrero (se elimina de la empresa y de su grupo)");
      Console.WriteLine("3- Contratar a un jefe de obra (se asigna a una obra existente) y se le asocia un grupo de obreros libre.");
      Console.WriteLine("4- Submenu de impresión: listado de obreros, de obras en ejecución, de obras finalizadas y de jefes, porcentaje de obras de remodelación sin finalizar.");
      Console.WriteLine("5- Modificar el estado de avance de una obra");
      Console.WriteLine("6- Dar de baja a un jefe (se elimina de la empresa, se desvincula de la obra y se libera el grupo de obreros asignado)");
      Console.WriteLine("0 - Salir del programa.");
      Console.Write("Seleccione una (numero) opción: ");
      int opc = int.Parse(Console.ReadLine());
      Console.Clear();
      while (opc != 0)
      {
        switch (opc)
        {
          case 1:
            AltaRegistro();
            break;
          case 2:
            Console.WriteLine("Elimina un obrero.");
            break;
          case 3:
            Console.WriteLine("Contrata a un Jefe.");
            break;
          case 4:
            Console.Clear();
            SubMenu();
            break;
          case 5:
            Console.WriteLine("Modificar el estado de avance de obra.");
            break;
          case 6:
            Console.WriteLine("Dar de baja a un jefe.");
            break;
          case 0:
            Console.WriteLine("Saliendo del programa...");
            return;
          default:
            ErrorColor();
            Console.WriteLine("Número no reconocido.");
            DefaultColor();
            Console.Write("Presiona una tecla para intentar de nuevo.");
            Console.ReadKey(true);
            break;
        }

        Console.Clear();
        TituloColor();
        Console.WriteLine("---------> Menu principal <---------");
        DefaultColor();
        Console.WriteLine("1- Contratar un obrero nuevo (se agrega a la empresa y a un grupo)");
        Console.WriteLine("2- Eliminar un obrero (se elimina de la empresa y de su grupo)");
        Console.WriteLine("3- Contratar a un jefe de obra (se asigna a una obra existente) y se le asocia un grupo de obreros libre.");
        Console.WriteLine("4- Submenu de impresión: listado de obreros, de obras en ejecución, de obras finalizadas y de jefes, porcentaje de obras de remodelación sin finalizar.");
        Console.WriteLine("5- Modificar el estado de avance de una obra");
        Console.WriteLine("6- Dar de baja a un jefe (se elimina de la empresa, se desvincula de la obra y se libera el grupo de obreros asignado)");
        Console.WriteLine("0 - Salir del programa.");
        Console.Write("Seleccione una (numero) opción: ");
        opc = int.Parse(Console.ReadLine());
      }

    }

    public static void SubMenu()
    {
      TituloColor();
      Console.WriteLine("--------> SubMenu <----------");
      DefaultColor();
      Console.WriteLine("1- Listado de obreros");
      Console.WriteLine("2- Listado de Jefes");
      Console.WriteLine("3- Obras en ejecución.");
      Console.WriteLine("4- Obras finalizadas.");
      Console.WriteLine("5- Porcentaje de obras de remodelación sin finalizar.");
      Console.WriteLine("0- Volver al Menu Principal.");
      Console.Write("Seleccione una (numero) opción: ");
      int opc = int.Parse(Console.ReadLine());

      while (opc != 0)
      {
        switch (opc)
        {
          case 1:
            Console.Clear();
            Console.WriteLine("-----> Listado de obreros <-----");
            BDatos.ObrerosDatos();
            break;
          case 2:
            Console.WriteLine("Listado de Jefes.");
            break;
          case 3:
            Console.WriteLine("Obras en ejecución.");
            break;
          case 4:
            Console.WriteLine("Obras finalizadas.");
            break;
          case 5:
            Console.WriteLine("Porcentaje de obras de remodelación sin finalizar.");
            break;
          case 0:
            Console.WriteLine("Volviendo al Menu Principal...");
            break;
          default:
            ErrorColor();
            Console.WriteLine("Número no reconocido.");
            DefaultColor();
            Console.Write("Presiona una tecla para intentar de nuevo.");
            Console.ReadKey(true);
            break;
        }
        Console.Clear();
        TituloColor();
        Console.WriteLine("--------> SubMenu <----------");
        DefaultColor();
        Console.WriteLine("1- Listado de obreros");
        Console.WriteLine("2- Listado de Jefes");
        Console.WriteLine("3- Obras en ejecución.");
        Console.WriteLine("4- Obras finalizadas.");
        Console.WriteLine("5- Porcentaje de obras de remodelación sin finalizar.");
        Console.WriteLine("0- Volver al Menu Principal.");
        Console.Write("Seleccione una (numero) opción: ");
        opc = int.Parse(Console.ReadLine());
      }


    }
    public static void TituloColor()
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.BackgroundColor = ConsoleColor.Black;
    }
    public static void ErrorColor()
    {
      Console.ForegroundColor = ConsoleColor.White;
      Console.BackgroundColor = ConsoleColor.Red;
    }
    public static void DefaultColor()
    {
      Console.ForegroundColor = ConsoleColor.Gray;
      Console.BackgroundColor = ConsoleColor.Black;
    }

    public static void AltaRegistro()
    {
      Console.WriteLine("Contrata un obrero nuevo.");
      Console.Write("Ingrese Nombre: ");
      string nombre = Console.ReadLine();
      Console.Write("Ingrese Apellido: ");
      string apellido = Console.ReadLine();
      Console.Write("Ingrese Número de D.N.I: ");
      int dni = int.Parse(Console.ReadLine());
      Console.Write("Ingrese Numero de Legajo: ");
      int nroLegajo = int.Parse(Console.ReadLine());
      Console.Write("Ingrese el Sueldo: ");
      double sueldo = double.Parse(Console.ReadLine());
      Console.Write("Ingrese su Cargo: ");
      string cargo = Console.ReadLine();
      Obrero objetoObrero = new Obrero(nombre, apellido, dni, nroLegajo, sueldo, cargo);


      Console.Clear();
      Console.WriteLine("El contenido del objeto es: {0}", objetoObrero);
      Console.Write("Presione una tecla para continuar...");
      Console.ReadKey(true);

    }
  }
}
