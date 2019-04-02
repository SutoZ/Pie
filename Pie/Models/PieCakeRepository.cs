using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pie.Models
{
    public class PieCakeRepository : IPieRepository
    {
        private readonly AppDbContext _dbContext;

        public PieCakeRepository(AppDbContext appDbContext) => _dbContext = appDbContext;

        public IEnumerable<PieCake> GetAllPies() => _dbContext.Pies;
        public PieCake GetPieById(int id) => _dbContext.Pies.FirstOrDefault(x => x.Id == id);
    }
}
