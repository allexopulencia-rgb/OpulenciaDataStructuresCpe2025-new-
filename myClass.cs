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

        public static void formShow(Form formToShow, Panel formToShowParent)
        {
            formToShow.TopLevel = false;
            formToShow.WindowState = FormWindowState.Maximized;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Parent = formToShowParent;
            formToShow.Visible = true;

            formToShowParent.Controls.Clear();
            formToShowParent.Controls.Add(formToShow);
        }


        public static void formClose(Form formToClose)
        {
            Form openForm = null;
            for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            {
                openForm = Application.OpenForms[index];
                if (openForm != formToClose && !(openForm is Main))
                {
                    openForm.Close();
                    openForm.Dispose();
                    openForm = null;
                }
            }
        }
    }
}
