using System;

namespace constructora
{
	public class ObreroJefe : GrupoObrero
	{
		public string Tarea;
		private double Bono;

		public ObreroJefe(string tarea, double bono, string nombre, string apellido, int dni, int nrolegajo, double sueldo, string cargo) :
			base(nrolegajo, sueldo, cargo, nombre, apellido, dni)
		{
			Tarea = tarea;
			Bono = bono;
		}
	}
}
