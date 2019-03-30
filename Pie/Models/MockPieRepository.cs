using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pie.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<PieCake> _pies;

        public MockPieRepository()
        {
            if (_pies == null)
                InitliaziePies();
        }

        private void InitliaziePies()
        {
            _pies = new List<PieCake>
            {
                new PieCake {Id = 1, Name ="Apple pie", Price = 5, IsPieOfTheWeek = true, LongDescription = "lorem ipsum"}
            };
        }

        public PieCake GetPieById(int id) => _pies.FirstOrDefault(x => x.Id == id);


        public IEnumerable<PieCake> GetAllPies() => _pies;

    }
}
