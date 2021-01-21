using System;

  class Desafio {
    static void Main() {
      string [] entrada = Console.ReadLine().Split(" ");
      int placa = int.Parse(entrada[0]);
      int N = int.Parse(entrada[1]);
      int toltalDePlacas = placa * N;
      for (int i = 10; i <= 90; i += 10) {
        double percursoTotal = (double)toltalDePlacas / 100 * i;
        Console.Write(Math.Ceiling(percursoTotal) + " ");
      }
    }
}

