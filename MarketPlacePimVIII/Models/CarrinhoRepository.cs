using System.Collections.Generic;
using System.Linq;

public class CarrinhoRepository
{
    private readonly MarketplacePimVIII _context;

    public CarrinhoRepository(MarketplacePimVIII context)
    {
        _context = context;
    }

    public object EntityState { get; private set; }

    public void Adicionar(MarketplacePimVIII.Models.Carrinho entidade)
    {
        _context.Carrinhos.Add(entidade);
        _context.SaveChanges();
    }

    public void Atualizar(MarketplacePimVIII.Models.Carrinho entidade)
    {
        _context.Entry(entidade).State = EntityState;
        _context.SaveChanges();
    }

    public void Excluir(MarketplacePimVIII.Models.Carrinho entidade)
    {
        _context.Carrinhos.Remove(entidade);
        _context.SaveChanges();
    }

    public MarketplacePimVIII.Models.Carrinho ObterPorId(int id)
    {
        return _context.Carrinhos.Find(id);
    }

    public List<MarketplacePimVIII.Models.Carrinho> ObterTodos()
    {
        return _context.Carrinhos.ToList();
    }
}
