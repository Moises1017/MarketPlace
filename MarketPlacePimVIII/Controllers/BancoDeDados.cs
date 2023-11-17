using System;
using System.Collections.Generic;
using System.Linq;

namespace MarketPlacePIMVIII.Controllers
{
    public class CarrinhoRepository
    {
        private const string SqlServer = "SqlServer";
        private const string MySql = "MySql";
        private const string Simulador = "Simulador";

        private readonly string _tipoBancoDeDados;

        public CarrinhoRepository(string tipoBancoDeDados)
        {
            _tipoBancoDeDados = tipoBancoDeDados;
        }

        public void Adicionar(Carrinho entidade)
        {


            Console.WriteLine($"Adicionando carrinho no banco de dados {_tipoBancoDeDados}");
        }

        public void Atualizar(Carrinho entidade)
        {


            Console.WriteLine($"Atualizando carrinho no banco de dados {_tipoBancoDeDados}");
        }

        public void Excluir(Carrinho entidade)
        {


            Console.WriteLine($"Excluindo carrinho no banco de dados {_tipoBancoDeDados}");
        }

        public Carrinho ObterPorId(int id)
        {

            Console.WriteLine($"Obtendo carrinho por ID no banco de dados {_tipoBancoDeDados}");
            return null;
        }

        public List<Carrinho> ObterTodos()
        {


            Console.WriteLine($"Obtendo todos os carrinhos no banco de dados {_tipoBancoDeDados}");
            return new List<Carrinho>();
        }
    }

    public class Carrinho
    {

    }
}
