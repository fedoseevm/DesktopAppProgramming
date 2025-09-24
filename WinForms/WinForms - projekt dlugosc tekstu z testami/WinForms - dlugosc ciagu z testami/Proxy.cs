using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms___dlugosc_ciagu_z_testami
{
    internal class Proxy
    {
        IAdapter adapter = new Adapter();

        public string KomunikatTextDlug(string text)
        {
            return "Zostało: " + adapter.dlug(text);
        }
    }
}
