using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez.tabuleiro
{
    internal class TabuleiroExeption: Exception
    {
        public TabuleiroExeption(string msg):base(msg) { }
    }
}
