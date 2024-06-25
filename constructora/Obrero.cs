using System;

namespace constructora
{
	public class Obrero : Persona
	{
		// Atributos
		protected int NroLegajo;
		protected  double Sueldo;
		public string Cargo;
		
		// Constructor
		public Obrero(string nombre, string apellido, int dni, int nrolegajo, double sueldo, string cargo)
			: base(nombre, apellido, dni)
		{
			NroLegajo = nrolegajo;
			Sueldo = sueldo;
			Cargo = cargo;
		}
		public override string ToString()
		{
			return string.Format("[Nombre: {0}, Apellido: {1}, Obrero ID: {2}, NroLegajo: {3}, Sueldo: {4}, Cargo: {5}]",Nombre, Apellido, ID, NroLegajo, Sueldo, Cargo);
		}
	}
}
