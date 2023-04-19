using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra
{
    internal class Conversadores : Npc
    {
        
        string text1;
        string text2;
        string text3;

        public Conversadores(string text1, string text2, string text3)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
        }
    }
}