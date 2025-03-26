using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms___dlugosc_ciagu_z_testami
{
    public class DAO : IDao
    {
        public int dlug(string text)
        {
            return text.Length;
        }
    }
}
