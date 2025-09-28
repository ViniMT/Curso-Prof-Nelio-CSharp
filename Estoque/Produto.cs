using System;
using System.Globalization;

namespace POO.Produto
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        
        public void AdicionarProdutos(int quantidade)
        {
            quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"Produto: {Nome}" +
            $"\nValor: R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)} " +
            $"\nQuantidade: {Quantidade}" +
            $"\nQuantidade total no estoque: {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}