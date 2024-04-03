using System.Drawing;
using System.Windows.Forms;
using System;

namespace Spisok_Del_TryToDo.Class
{
    internal class EventsPanel
    {
        public void CommonMouseEnter(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                panel.BackColor = Color.LightGray;
            }
        }

        public void CommonMouseLeave(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                panel.BackColor = Color.White;
            }
        }
    }
}
