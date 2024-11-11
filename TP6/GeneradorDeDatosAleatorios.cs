/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 25/10/2024
 * Hora: 09:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of GeneradorDeDatosAleatorios.
	/// </summary>
	public class GeneradorDeDatosAleatorios
	{
		static Random rnd = new Random();
		string letras;
		public GeneradorDeDatosAleatorios()
		{
			this.letras = "qwertyuiopasdfghjklzxcvbnm";
		}
		
		public int numeroAleatorio(int max){
			return GeneradorDeDatosAleatorios.rnd.Next(0,max);
		}
		
		public string stringAleatorio(int cant){
			string respuesta = "";
			if(cant > 0){
				for (int i = 0; i < cant; i++) {
					respuesta = respuesta + letras[GeneradorDeDatosAleatorios.rnd.Next(0,26)];
				}
			}
			return respuesta;
		}
		
		
	}
}
