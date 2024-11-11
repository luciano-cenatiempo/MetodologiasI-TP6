/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 29/10/2024
 * Hora: 10:32
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of FabricaDeAlumnos.
	/// </summary>
	public class FabricaDeAlumnos : FabricaDeComparables
	{
		public FabricaDeAlumnos()
		{
		}
		
		public override Comparable crearAleatorio(){
			return new Alumno( aleatorio.stringAleatorio(5),
			                  aleatorio.numeroAleatorio(1000000),
			                  aleatorio.numeroAleatorio(9999),
			                  aleatorio.numeroAleatorio(10));
			                  
		}
		
		public  override Comparable crearPorTeclado(){
			Alumno alu = new Alumno();
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
