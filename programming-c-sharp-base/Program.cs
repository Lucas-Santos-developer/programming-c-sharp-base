  class Program 
  {
    static void Main(string[] args)
    {
      /*
      - O tipo sbyte tem a capacidade de armazenar valores de até 1 Byte.
      - Esses valores vão de -128 até 127.
      - Ele pode ser sinalizado visto que o número pode ser negativo.
      */
      sbyte number = 127;
      /*
      - Caso 
      */
      // sbyte number = 128; || Gera um erro de compilação pois o valor ecxedeu os valores limites deste tipo
      System.Console.WriteLine(number);
    }
  }