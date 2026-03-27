using System;

class Program
{
    static void Main(string[] args)
    {
        List<Gasto> gastos = new List<Gasto>();
        int proximoId = 1;

        int opcao = -1;

        while (opcao != 0)
        {
            Console.WriteLine("1 - Adicionar gasto");
            Console.WriteLine("2 - Listar gastos");
            Console.WriteLine("3 - Atualizar gasto");
            Console.WriteLine("4 - Remover gasto");
            Console.WriteLine("5 - Total gasto");
            Console.WriteLine("0 - Sair");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)

            {
                case 1:
                    Gasto novo = new Gasto();

                    novo.Id = proximoId++;

                    Console.Write("Nome: ");
                    novo.Nome = Console.ReadLine();

                    Console.Write("Valor: ");
                    novo.Valor = double.Parse(Console.ReadLine());

                    Console.Write("Categoria: ");
                    novo.Categoria = Console.ReadLine();

                    gastos.Add(novo);

                    Console.WriteLine("Gasto adicionado!");
                    break;
                case 2:
                    foreach (Gasto g in gastos)
                    {
                        Console.Write($" {g.Id} | {g.Nome} | {g.Valor} | {g.Categoria} | {g.Data} |\n");
                        Console.WriteLine();

                    }
                        
                    break;
            }
        }

        
    }
    
}

public class Gasto
{
    public int Id;
    public string Nome = null!;
    public double Valor;
    public string Categoria = null!;
    public DateTime Data;

    
}