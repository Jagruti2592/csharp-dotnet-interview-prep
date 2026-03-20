using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCommerce.Domain.ValueObjects
{
    public record UserSummary(
        string Name,
        string Email);
}
