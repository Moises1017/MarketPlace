using System;

namespace MarketPlacePIMVIII.Controllers
{
    public interface ICarrinhoRepository
    {
        void Adicionar(Carrinho entidade);
        void Atualizar(Carrinho entidade);
        void Excluir(Carrinho entidade);
        Carrinho ObterPorId(int id);

    }

    public enum TipoBancoDeDados
    {
        SqlServer,
        MySql,
        Simulador
    }

    public class GerenciadorBancoDeDados : ICarrinhoRepository
    {
        private readonly TipoBancoDeDados _tipoBancoDeDados;

        public GerenciadorBancoDeDados(TipoBancoDeDados tipoBancoDeDados)
        {
            _tipoBancoDeDados = tipoBancoDeDados;
        }

        public void Adicionar(Carrinho entidade)
        {
            switch (_tipoBancoDeDados)
            {
                case TipoBancoDeDados.SqlServer:

                    Console.WriteLine("Adicionando no SQL Server");
                    break;

                case TipoBancoDeDados.MySql:

                    Console.WriteLine("Adicionando no MySQL");
                    break;

                case TipoBancoDeDados.Simulador:

                    Console.WriteLine("Adicionando no Simulador");
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Atualizar(Carrinho entidade)
        {

        }

        public void Excluir(Carrinho entidade)
        {

        }

        public Carrinho ObterPorId(int id)
        {

            return null; 
        }
    }
}
