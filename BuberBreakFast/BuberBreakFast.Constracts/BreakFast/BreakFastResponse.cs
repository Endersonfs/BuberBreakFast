using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberBreakFast.Constracts.BreakFast
{
    public record BreackFastResponse
    (
        Guid Id,
        string Name,
        string Description,
        DateTime StartDateTime,
        DateTime EndDateTime,
        DateTime lastModifyDateTime,
        List<string> Savory,
        List<string> Sweet
    );
}
