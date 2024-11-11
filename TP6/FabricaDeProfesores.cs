/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 29/10/2024
 * Hora: 14:25
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of FabricaDeProfesores
	/// </summary>
	public class FabricaDeProfesores : FabricaDeComparables
	{
		public FabricaDeProfesores()
		{
		}
		
		public  override Comparable crearAleatorio(){
			return new Profesor( aleatorio.stringAleatorio(5),
			                  aleatorio.numeroAleatorio(1000000),
			                  aleatorio.numeroAleatorio(9999));
			                  
		}
		
		public  override Comparable crearPorTeclado(){
			Profesor prof = new Profesor();
			Console.WriteLine("Nombre:");
			prof.setNombre( lector.stringPorTeclado());
			Console.WriteLine("DNI:");
			prof.setDni(lector.numeroPorTeclado());
			Console.WriteLine("Antiguedad:");
			prof.setAntiguedad(lector.numeroPorTeclado());
			
			return prof;
		}
	}
}
