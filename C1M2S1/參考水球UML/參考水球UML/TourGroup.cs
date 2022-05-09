﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 參考水球UML
{
    internal class TourGroup
    {
        private List<Adventure> adventures;

        public List<Adventure> Adventures { get => adventures; set => adventures = value; }

        public void add(Adventure adventure)
        {
            adventures.Add(adventure);
            adventure.TourGroup = this;
        }
    }
}
