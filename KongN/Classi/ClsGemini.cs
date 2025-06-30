using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongN.Classi
{
    internal class ClsGemini
    {
       

public class GestionePulsantiToolbar
    {
        private ToolStrip _toolbar;

        public GestionePulsantiToolbar(ToolStrip toolbar)
        {
            _toolbar = toolbar;
        }

        public void AbilitaDisabilitaPulsanti(ToolStripItem pulsantePremuto, bool abilita)
        {
            if (pulsantePremuto == null)
            {
                return; // Gestisci il caso in cui il pulsante premuto è nullo
            }

            // Disabilita o abilita tutti i pulsanti tranne quello premuto
            foreach (ToolStripItem item in _toolbar.Items)
            {
                if (item == pulsantePremuto)
                {
                    item.Enabled = abilita;
                }
            }
        }

        public void AbilitaDisabilitaPulsanti(ToolStripItem[] pulsantiDaGestire, bool abilita)
        {
            if (pulsantiDaGestire == null || pulsantiDaGestire.Length == 0)
            {
                return; // Gestisci il caso in cui l'array è nullo o vuoto
            }

            // Disabilita o abilita solo i pulsanti specificati
            foreach (ToolStripItem item in _toolbar.Items)
            {
                if (pulsantiDaGestire.Contains(item))
                {
                    item.Enabled = abilita;
                }
            }
        }

    }
}
}



/*Come utilizzare questa classe
Crea un'istanza della classe GestionePulsantiToolbar nel tuo form, passando la tua ToolStrip come argomento:
C#

private GestionePulsantiToolbar _gestionePulsanti;

public Form1()
{
InitializeComponent();
_gestionePulsanti = new GestionePulsantiToolbar(toolStrip1);
}
Nel gestore eventi Click di un pulsante della toolbar, chiama il metodo AbilitaDisabilitaPulsanti, passando il pulsante premuto e un valore booleano per abilitare o disabilitare gli altri pulsanti:
C#

private void mioPulsante_Click(object sender, EventArgs e)
{
ToolStripItem pulsantePremuto = (ToolStripItem)sender;
_gestionePulsanti.AbilitaDisabilitaPulsanti(pulsantePremuto, false); // Disabilita gli altri pulsanti
}
Se desideri abilitare o disabilitare solo alcuni pulsanti specifici, puoi creare un array di ToolStripItem contenente i pulsanti desiderati e passare questo array al metodo AbilitaDisabilitaPulsanti:
C#

ToolStripItem[] pulsantiDaGestire = new ToolStripItem[] { mioPulsante1, mioPulsante2
};
_gestionePulsanti.AbilitaDisabilitaPulsanti(pulsantiDaGestire, false); // Disabilita solo i puls*/