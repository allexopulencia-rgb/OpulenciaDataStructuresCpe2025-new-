using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpulenciaDataStructureCpe2025
{
    public class myClass
    {

        public static void DisplayDSvalue(ListBox myListbox, IEnumerable myCollection)
        {
            myListbox.Items.Clear();
            foreach (var item in myCollection)
            {
                myListbox.Items.Add(item);
            }
        }
    }
}
