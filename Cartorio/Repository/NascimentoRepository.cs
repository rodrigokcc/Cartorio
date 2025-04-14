using Cartorio.Data;
using Cartorio.Interfaces;
using Cartorio.Models;
using Microsoft.EntityFrameworkCore;

namespace Cartorio.Repository
{
    public class NascimentoRepository: INascimentoRepository
    {
        AppDbContext _context;
        public NascimentoRepository(AppDbContext context)
        {
            _context = context;
        }
        public bool Add(Nascimento nascimento)
        {
            _context.Nascimentos.Add(nascimento); // Adiciona o registro ao banco
            var saved = _context.SaveChanges(); // Salva as alterações
            return saved > 0; // Retorna true se o registro foi salvo com sucesso
        }

        public async Task<IEnumerable<Nascimento>> GetByDateRange(DateTime startDate, DateTime endDate)
        {
            return await _context.Nascimentos
                .Where(n => n.DataDeNascimento >= startDate && n.DataDeNascimento <= endDate)
                .ToListAsync(); // Filtra os registros de nascimento no intervalo de datas
        }
    }
    
}
