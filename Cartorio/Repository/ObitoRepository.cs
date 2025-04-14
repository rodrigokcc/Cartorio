using Cartorio.Data;
using Cartorio.Interfaces;
using Cartorio.Models;


namespace Cartorio.Repository
{
    public class ObitoRepository : IObitoRepository
    {
         AppDbContext _context;
         public ObitoRepository(AppDbContext context)
         {
             _context = context;
         }
         public bool Add(Obito obito)
         {
             _context.Obitos.Add(obito); // Adiciona o registro ao banco
             var saved = _context.SaveChanges(); // Salva as alterações
             return saved > 0; // Retorna true se o registro foi salvo com sucesso
         }
    }
}

