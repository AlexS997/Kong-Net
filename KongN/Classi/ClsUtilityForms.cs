using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongN.Classi
{
    static class ClsUtilityForms
    {
       
        
            public static Form LoadForm<T>(Form MdiParent) where T : Form, new()
            {

                foreach (Form form in Application.OpenForms)
                {


                    if (form.GetType() == typeof(T))
                    {
                        form.Activate();
                        return Form.ActiveForm;
                    }


                }

                T newForm = new T();
                newForm.MdiParent = MdiParent;
                newForm.Show();
                return newForm;


            }

        }
    }

