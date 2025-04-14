using Cartorio.Data;
using Cartorio.Interfaces;
using Cartorio.Models;

namespace Cartorio.Repository
{
    public class CasamentoRepository: ICasamentoRepository
    {
        AppDbContext _context;

        public CasamentoRepository(AppDbContext context)
        {
            _context = context;
        }
        public bool Add(Casamento casamento)
        {
            _context.Casamentos.Add(casamento); // Adiciona o registro ao banco
            var saved = _context.SaveChanges(); // Salva as alterações
            return saved > 0; // Retorna true se o registro foi salvo com sucesso
        }
    }
    
}
