using Cartorio.Models;

namespace Cartorio.Interfaces
{
    public interface INascimentoRepository
    {
        bool Add(Nascimento nascimento);
        Task<IEnumerable<Nascimento>> GetByDateRange(DateTime startDate, DateTime endDate);

    }
}
