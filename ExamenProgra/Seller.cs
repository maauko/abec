﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra
{
    internal class Seller : Npc, IshowData
    {
        float money;
        List<Item> list;

        public Seller(float money)
        {
            this.money = money;
        }
    }
}
