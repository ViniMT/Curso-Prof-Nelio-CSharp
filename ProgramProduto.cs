using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course
{
    class ProgramProduto
    {
        static void Main(string[] args)
        {
            Produto p;
            p = new Produto();

            Console.WriteLine("Insira os dados do produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.WriteLine("Digite a quantiade de produtos a adicionar ao estoque");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados" + p);
            Console.WriteLine();

            Console.WriteLine("Digite a quantiade de produtos a remover do estoque");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados" + p);
            Console.WriteLine();

        }
    }
}
