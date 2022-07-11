//Contagem de C�dulas

/*
Fa�a a leitura de um valor inteiro. Em seguida, calcule o menor n�mero de notas poss�veis (c�dulas)
onde o valor pode ser decomposto. As notas que voc� deve considerar s�o de 100, 50, 20, 10, 5, 2 e 1. 
Na sequ�ncia mostre o valor lido e a rela��o de notas necess�rias.

Entrada
Voc� receber� um valor inteiro N (0 < N < 1000000).

Sa�da
Exiba o valor lido e a quantidade m�nima de notas de cada tipo necess�rias, seguindo o exemplo de sa�da abaixo. 
Ap�s cada linha deve ser imprimido o fim de linha.
*/

using System;

namespace DIO
{
  class Program
  {
	static void Main(string[] args)
    {
		string valorEntrada = Console.ReadLine();
		int valor = int.Parse(valorEntrada);
		CalculaValorApagar(valor);
	}
		public static void CalculaValorApagar(int valorPagar)
		{
        int apagar;
        int[] notas = new int[] { 100, 50, 20, 10, 5, 2, 1 };
        int[] totalNotas = new int[7];


        for (int v = 0; v < 1; v++)
        {
			System.Console.WriteLine(valorPagar);

            apagar = valorPagar;

            for (int i = 0; i < 7; i++)
            {
                if (apagar >= notas[i])
                {
                    totalNotas[i] = apagar / notas[i];
                    apagar = apagar - totalNotas[i] * notas[i];
                }
                    System.Console.WriteLine(totalNotas[i] + " nota(s) de R$ " + notas[i] + ",00");
            }
                Array.Clear(totalNotas, 0, totalNotas.Length);
            }
        }
	}
}
