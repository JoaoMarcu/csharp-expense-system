using System;

class Program
{
    static void Main()
    {
        List<Gasto> gastos = [];

        int proximoId = 1;

        int opcao = -1;

        while (opcao!=0)
        {
            Console.WriteLine("\n1 - Adicionar gasto");
            Console.WriteLine("2 - Listar gastos");
            Console.WriteLine("3 - Atualizar gasto");
            Console.WriteLine("4 - Remover gasto");
            Console.WriteLine("5 - Total gasto");
            Console.WriteLine("0 - Sair\n");

            Console.Write("Escolha uma das opções:");
            string entrada = Console.ReadLine()!;
            Console.Clear();


            if (int.TryParse(entrada, out int opcaoDig))
            {
                opcao = opcaoDig;

                switch (opcao)

                {
                    case 1:
                        Gasto novo = new()
                        {
                            Id = proximoId++,
                            Data = DateTime.Now
                        };

                        Console.WriteLine("1 - Adicionar gasto\n");

                        Console.Write("Nome: ");
                        novo.Nome = Console.ReadLine()!;

                        Console.Write("Valor: ");
                        novo.Valor = double.Parse(Console.ReadLine()!);

                        Console.Write("Categoria: ");
                        novo.Categoria = Console.ReadLine()!;

                        gastos.Add(novo);

                        Console.WriteLine("Gasto adicionado!");
                        Avançar();
                        break;
                    case 2:
                        Console.WriteLine("2 - Listar gastos\n");

                        if (gastos.Count == 0)
                        {
                            Console.WriteLine("Nenhum gasto cadastrado.");
                        }
                        else
                        {
                            foreach (Gasto g in gastos)
                            {
                                Console.WriteLine($"ID: {g.Id} | {g.Nome} | R$ {g.Valor} | {g.Categoria} | add in: {g.Data.ToString("dd/MM/yyyy HH:mm")}");

                            }
                        }
                        Avançar();
                        break;
                    case 3:
                        Console.WriteLine("3 - Atualizar gasto\n");

                        Console.Write("Digite o ID: ");
                        int id = int.Parse(Console.ReadLine()!);

                        var gasto = gastos.Find(g => g.Id == id);

                        if (gasto != null)
                        {
                            Console.Write("Novo nome: ");
                            gasto.Nome = Console.ReadLine()!;

                            Console.Write("Novo valor: ");
                            gasto.Valor = double.Parse(Console.ReadLine()!);

                            Console.Write("Nova categoria: ");
                            gasto.Categoria = Console.ReadLine()!;

                            Console.WriteLine("Atualizado!");
                        }
                        else
                        {
                            Console.WriteLine("Não encontrado!");
                        }
                        Avançar();
                        break;
                    case 4:
                        Console.WriteLine("4 - Remover gasto\n");

                        Console.Write("Digite o ID: ");
                        id = int.Parse(Console.ReadLine()!);

                        gasto = gastos.Find(g => g.Id == id);

                        if (gasto != null)
                        {
                            gastos.Remove(gasto);
                            Console.WriteLine("Removido!");
                        }
                        else
                        {
                            Console.WriteLine("Não encontrado!");
                        }
                        Avançar();
                        break;
                    case 5:
                        Console.WriteLine("5 - Total gasto\n");

                        double total = 0;

                        foreach (var g in gastos)
                        {
                            total += g.Valor;
                        }

                        Console.WriteLine($"Total gasto: R$ {total}");
                        Avançar();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Avançar();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                Avançar();
            }


        }
    }
    
    public static void Avançar()
    {
        Console.WriteLine("\nPressione qualquer tecla...");
        Console.ReadKey();
        Console.Clear();
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