using System;

namespace constructora
{
	public class GrupoObrero : Obrero
	{
		public int CantidadObrero;
		public int Grupo;
		public string ObreroJefe;

		public GrupoObrero(int cantidadobrero, int grupo, string obreroJefe, int nrolegajo, double sueldo, string cargo) : base(nrolegajo, suelda, cargo)
		{
			CantidadObrero = cantidadobrero;
			Grupo = grupo;
			ObreroJefe = obreroJefe;
		}
	}
}
