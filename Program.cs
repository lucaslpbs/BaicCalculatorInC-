Menu();

static void Menu()
{
  Console.Clear();

  Console.WriteLine("Escolha qual ação aritimetica quer fazer: ");

  Console.WriteLine("Soma: 1 \nSubitracao: 2 \nMultiplicação: 3 \nDivisão: 4\n5: Sair");
  short decisao = short.Parse(Console.ReadLine());

  switch (decisao)
  {
    case 1:
      Soma();
      break;
    case 2:
      Subitracao();
      break;
    case 3:
      Multiplicacao();
      break;
    case 4:
      Divisao();
      break;
    case 5:
      Environment.Exit(0);
      break;
    default: Menu(); break;
  }

}

static void Soma()
{
  Console.Clear();
  Console.WriteLine("Primeiro valor:");
  float v1 = float.Parse(Console.ReadLine());
  Console.WriteLine("Segundo valor:");
  float v2 = float.Parse(Console.ReadLine());

  Console.WriteLine("");

  float resultado = v1 + v2;
  Console.WriteLine($"O resultado da soma é {resultado}");

  Console.ReadKey();

  Menu();
}
static void Subitracao()
{
  Console.Clear();
  Console.WriteLine("Primeiro valor:");
  float v1 = float.Parse(Console.ReadLine());
  Console.WriteLine("Segundo valor:");
  float v2 = float.Parse(Console.ReadLine());

  Console.WriteLine("");

  float resultado = v1 - v2;
  Console.WriteLine($"O resultado da Subitracao é {resultado}");

  Console.ReadKey();

  Menu();
}
static void Multiplicacao()
{
  Console.Clear();
  Console.WriteLine("Primeiro valor:");
  float v1 = float.Parse(Console.ReadLine());
  Console.WriteLine("Segundo valor:");
  float v2 = float.Parse(Console.ReadLine());

  Console.WriteLine("");

  float resultado = v1 * v2;
  Console.WriteLine($"O resultado da Multiplicacao é {resultado}");

  Console.ReadKey();

  Menu();
}
static void Divisao()
{
  Console.Clear();
  Console.WriteLine("Primeiro valor:");
  float v1 = float.Parse(Console.ReadLine());
  Console.WriteLine("Segundo valor:");
  float v2 = float.Parse(Console.ReadLine());

  Console.WriteLine("");

  float resultado = v1 / v2;
  Console.WriteLine($"O resultado da Divisao é {resultado}");

  Console.ReadKey();

  Menu();
}