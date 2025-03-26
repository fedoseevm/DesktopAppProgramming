using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms___dlugosc_ciagu_z_testami
{
    internal class Adapter : IAdapter, IDao
    {
        public const int LIMIT = 10;
        public int dlug(string text)
        {
            if (text.Length > LIMIT) throw new ArgumentException();
            return LIMIT - text.Length;
        }
    }
}
