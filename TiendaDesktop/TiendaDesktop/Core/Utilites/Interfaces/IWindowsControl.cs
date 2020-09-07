using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Recursos.Interfaces
{
    interface IWindowsControl
    {
        void BtnClose_Click(object sender, EventArgs e);
        void BtnResize_Click(object sender, EventArgs e);
        void BtnMin_Click(object sender, EventArgs e);
    }
}
