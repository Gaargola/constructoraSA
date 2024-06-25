using System;
using System.Collections.Generic;

namespace constructora
{
	public static class BDatos
	{
		public static void ObrerosDatos()
		{
			Guid id = Guid.NewGuid();
			List<Obrero> listaObreros = new List<Obrero>();

			Obrero obrero1 = new Obrero("Juan", "Gonzales", 33344223, 711, 350000, "Capataz");
			Obrero obrero2 = new Obrero("Pedro", "Martínez", 44891234, 712, 280000, "Albañil");
			Obrero obrero3 = new Obrero("María", "López", 55672345, 713, 250000, "Peón");
			Obrero obrero4 = new Obrero("Luis", "Sánchez", 66783456, 714, 320000, "Plomero");
			Obrero obrero5 = new Obrero("Ana", "Rodríguez", 77894567, 715, 300000, "Electricista");
			Obrero obrero6 = new Obrero("Carlos", "Gómez", 88905678, 716, 380000, "Capataz");
			Obrero obrero7 = new Obrero("Laura", "Díaz", 99016789, 717, 270000, "Albañil");
			Obrero obrero8 = new Obrero("Javier", "Fernández", 101278900, 718, 290000, "Peón");
			Obrero obrero9 = new Obrero("Gabriela", "Pérez", 112390011, 719, 330000, "Plomero");
			Obrero obrero10 = new Obrero("Diego", "Hernández", 123401122, 720, 310000, "Electricista");
			Obrero obrero11 = new Obrero("Silvia", "García", 134512233, 721, 360000, "Capataz");
			Obrero obrero12 = new Obrero("Manuel", "Martínez", 145623344, 722, 260000, "Albañil");
			Obrero obrero13 = new Obrero("Fernanda", "López", 156734455, 723, 270000, "Peón");
			Obrero obrero14 = new Obrero("Ricardo", "Sánchez", 167845566, 724, 340000, "Plomero");
			Obrero obrero15 = new Obrero("Marcela", "Rodríguez", 178956677, 725, 320000, "Electricista");
			Obrero obrero16 = new Obrero("Juan", "Gómez", 189067788, 726, 370000, "Capataz");
			Obrero obrero17 = new Obrero("Patricia", "Díaz", 190178899, 727, 250000, "Albañil");
			Obrero obrero18 = new Obrero("Roberto", "Fernández", 201290010, 728, 300000, "Peón");
			Obrero obrero19 = new Obrero("Marta", "Pérez", 212301121, 729, 350000, "Plomero");
			Obrero obrero20 = new Obrero("Andrés", "Hernández", 223412232, 730, 330000, "Electricista");
			Obrero obrero21 = new Obrero("Alejandra", "García", 234523343, 731, 380000, "Capataz");
			Obrero obrero22 = new Obrero("Gonzalo", "Martínez", 245634454, 732, 260000, "Albañil");
			Obrero obrero23 = new Obrero("Camila", "López", 256745565, 733, 280000, "Peón");
			Obrero obrero24 = new Obrero("Sergio", "Sánchez", 267856676, 734, 360000, "Plomero");
			Obrero obrero25 = new Obrero("Valentina", "Rodríguez", 278967787, 735, 340000, "Electricista");
			Obrero obrero26 = new Obrero("Eduardo", "Gómez", 289078898, 736, 390000, "Capataz");
			Obrero obrero27 = new Obrero("Lorena", "Díaz", 290189909, 737, 270000, "Albañil");
			Obrero obrero28 = new Obrero("Daniel", "Fernández", 301290020, 738, 290000, "Peón");
			Obrero obrero29 = new Obrero("Lucía", "Pérez", 312401131, 739, 360000, "Plomero");
			Obrero obrero30 = new Obrero("Mateo", "Hernández", 323512242, 740, 350000, "Electricista");
			Obrero obrero31 = new Obrero("Carmen", "García", 334623353, 741, 380000, "Capataz");
			Obrero obrero32 = new Obrero("Ramón", "Martínez", 345734464, 742, 280000, "Albañil");
			Obrero obrero33 = new Obrero("Victoria", "López", 356845575, 743, 300000, "Peón");
			Obrero obrero34 = new Obrero("Emilio", "Sánchez", 367956686, 744, 370000, "Plomero");
			Obrero obrero35 = new Obrero("Julia", "Rodríguez", 378067797, 745, 330000, "Electricista");
			Obrero obrero36 = new Obrero("Martín", "Gómez", 389178808, 746, 400000, "Capataz");
			Obrero obrero37 = new Obrero("Adriana", "Díaz", 390289919, 747, 260000, "Albañil");
			Obrero obrero38 = new Obrero("Héctor", "Fernández", 401390020, 748, 310000, "Peón");
			Obrero obrero39 = new Obrero("Natalia", "Pérez", 412501131, 749, 380000, "Plomero");
			Obrero obrero40 = new Obrero("Pablo", "Hernández", 423612242, 750, 360000, "Electricista");


			listaObreros.AddRange(new[] {
				obrero1, obrero2, obrero3, obrero4, obrero5,
				obrero6, obrero7, obrero8, obrero9, obrero10,
				obrero11, obrero12, obrero13, obrero14, obrero15,
				obrero16, obrero17, obrero18, obrero19, obrero20,
				obrero21, obrero22, obrero23, obrero24, obrero25,
				obrero26, obrero27, obrero28, obrero29, obrero30,
				obrero31, obrero32, obrero33, obrero34, obrero35,
				obrero36, obrero37, obrero38, obrero39, obrero40
			});
			for (int i = 0; i < listaObreros.Count; i++)
			{
				Console.WriteLine(listaObreros[i]);
				Console.WriteLine("----------------------------------------------------------------");
			}
			Console.ReadKey(true);
		}
		public static void ObrasDatos()
		{
			List<Obras> listaObras = new List<Obras>();
			Obras obra1 = new Obras("Cemento", 2000, 10000, 1200000, 1000000);
			Obras obra2 = new Obras("Piedra", 2000, 10000, 1200000, 1000000);
			Obras obra3 = new Obras("Piedra", 2000, 10000, 1200000, 1000000);
			Obras obra4 = new Obras("Piedra", 2000, 10000, 1200000, 1000000);
			Obras obra5 = new Obras("Piedra", 2000, 10000, 1200000, 1000000);
			Obras obra6 = new Obras("Piedra", 2000, 10000, 1200000, 1000000);
			Obras obra7 = new Obras("Piedra", 2000, 10000, 1200000, 1000000);

			listaObras.AddRange(new[] {
				obra1, obra2, obra3, obra4, obra5,
				obra6, obra7
			});
			for (int i = 0; i < listaObras.Count; i++)
			{
				Console.WriteLine(listaObras[i]);
				Console.WriteLine("----------------------------------------------------------------");
			}
			Console.ReadKey(true);
		}
	}
}
