using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    internal class FormUtils
    {

        public static class FormUtilities
        {
            public static void HideModifyButton(Form form, int userRoleId)
            {
                if (userRoleId == 3) // 3 representa el rol de empleado
                {
                    var btnModify = form.Controls.Find("btnmodificar", true).FirstOrDefault();
                    if (btnModify != null)
                    {
                        btnModify.Visible = false;
                    }
                }
            }
        }
    }
}