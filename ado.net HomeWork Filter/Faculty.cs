using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ado.net_HomeWork_Filter
{
    public partial class Faculty
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
    }
}
