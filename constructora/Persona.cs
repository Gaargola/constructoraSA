using System;

namespace constructora
{
	public class Persona
	{
		public string Nombre;
		public string Apellido;
		protected int DNI;
		
		
		public Persona(string nombre, string apellido, int dni)
		{
			Nombre = nombre;
			Apellido = apellido;
			DNI = dni;
		}
	}
}
