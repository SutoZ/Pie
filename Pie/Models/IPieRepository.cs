using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pie.Models
{
    public interface IPieRepository
    {
        IEnumerable<PieCake> GetAllPies();
        PieCake GetPieById(int id);
    }
}
