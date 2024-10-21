/*
 * Created by Metodologías de Programación I
 * Activity 7. 
 * Chain of responsability and Singleton patterns 
 *
 * Antes de usar este código el alumno deberá agregar a la variable "ruta_archivo" de la clase 
 * "LectorDeArchivos" la ruta correspondiente a su equipo donde haya guardado el archvo con los datos
 * provistos por la cátedra (archivo datos.txt)
 *
 * IMPORTANTE *  
 * El código que está en este archivo SI puede modificarse para resolver la actividad solicitada
 * 
 */

using System;
using System.IO;
using MetodologíasDeProgramaciónI;

namespace ObtencionDeDatos
{
	public class LectorDeArchivos : BaseManejadorDatos
	{
		private static LectorDeArchivos instancia;
		
		// El alumno deberá agregar la ruta correspondiente a su equipo donde haya guardado el archvo con los datos
		private const string ruta_archivo = @"D:\Practicas-Facultad\Metodologia\Patrones-de-Diseño\datos.txt";
		// --------------------------------------------------------------------------------------------------------
		
		private StreamReader lector_de_archivos;
		
		private LectorDeArchivos():base()
		{
			lector_de_archivos = new StreamReader(ruta_archivo);
		}
		public static LectorDeArchivos GetInstancia()
		{
			if(instancia == null)
			{
				instancia = new LectorDeArchivos();
			}

			return instancia;
		}
		public override int ObtenerNumero(int max)
		{
			string linea = lector_de_archivos.ReadLine();

			if (double.TryParse(linea.Substring(0, linea.IndexOf('\t')), out double num))
			{
				return (int)num * max;
			}
			else if (siguienteManejador != null)
			{
				return siguienteManejador.ObtenerNumero(max);
			}
			else
			{
				throw new Exception("No se pudo obtener un numero");
			}
		}
		
		public override string ObtenerCadena(int cant)
		{
			string linea = lector_de_archivos.ReadLine();
			linea = linea.Substring(linea.IndexOf('\t')+1);
			cant = Math.Min(cant, linea.Length);

			if (!string.IsNullOrEmpty(linea))
			{
				return linea.Substring(0, cant);
			}
			else if(siguienteManejador != null)
			{
				return siguienteManejador.ObtenerCadena(cant);
			}
			else
			{
				throw new Exception("No se pudo obetner texto");
			}	
		}
    }
}
