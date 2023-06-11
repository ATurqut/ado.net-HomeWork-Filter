﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ado.net_HomeWork_Filter
{
    public partial class Lib
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public virtual ICollection<SCard> SCards { get; set; } = new List<SCard>();

        public virtual ICollection<TCard> TCards { get; set; } = new List<TCard>();
    }
}
