using System;

namespace constructora
{
	public class Obras : Persona
	{
		protected string ID;
		public string Tipo;
		public double Estado;
		protected double Costo;
		
		// Metodos
		public string ListarTerminado(){}
		public string ListarEnCurso(){}
		protected void ModificarEstado(){}
		public string ListarObrasRemodelacion(){}
		
		public Obras(string tipo, double estado, double costo, string id) :
			 base(nombre, apellido, dni)
		{
			Tipo = tipo;
			Estado = estado;
			Costo = costo;
			ID = id;
		}
		
	}
}
