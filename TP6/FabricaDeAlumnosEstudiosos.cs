/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 4/11/2024
 * Hora: 12:57
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of FabricaDeAlumnosEstudiosos.
	/// </summary>
	public class FabricaDeAlumnosEstudiosos : FabricaDeComparables
	{
		public FabricaDeAlumnosEstudiosos()
		{
		}
		
		public override Comparable crearAleatorio(){
			return new AlumnoMuyEstudioso( aleatorio.stringAleatorio(5),
			                  				aleatorio.numeroAleatorio(1000000),
			                  				aleatorio.numeroAleatorio(9999),
			                  				aleatorio.numeroAleatorio(11));
			                  
		}
		
		public  override Comparable crearPorTeclado(){
			AlumnoMuyEstudioso alu = new AlumnoMuyEstudioso();
			Console.WriteLine("Nombre:");
			alu.setNombre( lector.stringPorTeclado());
			Console.WriteLine("DNI:");
			alu.setDni(lector.numeroPorTeclado());
			Console.WriteLine("Legajo:");
			alu.setLegajo(lector.numeroPorTeclado());
			Console.WriteLine("Promedio:");
			alu.setPromedio(lector.numeroPorTeclado());
			
			return alu;
		}
	}
}
