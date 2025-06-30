using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongN.Classi
{
    public class ButtonManager
    {
        private BindingNavigator _navigator;
        private Dictionary<string, ToolStripButton> _buttons;
        public bool AutoManageNavigator { get; set; } = true;

        public ButtonManager(BindingNavigator navigator)
        {
            _navigator = navigator;
            _buttons = new Dictionary<string, ToolStripButton>();

            foreach (var item in _navigator.Items)
            {
                if (item is ToolStripButton button)
                {
                    _buttons[button.Name] = button;
                    button.Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (!AutoManageNavigator)
            {
                return;
            }

            if (sender is ToolStripButton clickedButton)
            {
                if (clickedButton.Name == "btnNext" || clickedButton.Name == "btnPreviews" || clickedButton.Name == "btnFirst" || clickedButton.Name == "btnLast")
                {
                    return;
                }

                if (clickedButton.Name == "btnDelete")
                {
                    return;
                }

                if (clickedButton.Name == "btnSave")
                {
                    return;
                }

                //Buttons used only in FrmAgenda
                if (clickedButton.Name == "btnADD" || clickedButton.Name == "btnEDIT" || clickedButton.Name == "btnPassaAStorico")
                {
                    return;
                }

                HandleButtonClick(clickedButton);
            }
        }

        internal void HandleButtonClick(ToolStripButton clickedButton)
        {
            DisableAllButtons();

            foreach (var button in _buttons.Values)
            {
                button.Enabled = true; // Abilita tutti i pulsanti
            }

            switch (clickedButton.Name)
            {
                case "btnAdd":
                    clickedButton.Enabled = false;
                    foreach (var button in _buttons.Values)
                    {
                        button.Enabled = false; // Disabilita tutti i pulsanti
                    }
                    EnableButton("btnUndo");
                    EnableButton("btnSave");
                    DisableButton("btnPrint");
                    DisableButton("btnRefresh");
                    DisableButton("btnSearch");
                    break;
                case "btnDelete":
                    foreach (var button in _buttons.Values)
                    {
                        button.Enabled = true; // Abilita tutti i pulsanti
                    }
                    clickedButton.Enabled = false;
                    break;
                case "btnEdit":
                    foreach (var button in _buttons.Values)
                    {
                        button.Enabled = false; // Disabilita tutti i pulsanti
                    }
                    EnableButton("btnUndo");
                    EnableButton("btnSave");
                    DisableButton("btnPrint");
                    DisableButton("btnRefresh");
                    DisableButton("btnSearch");
                    break;
                case "btnUndo":
                    foreach (var button in _buttons.Values)
                    {
                        button.Enabled = true; // Abilita tutti i pulsanti
                    }
                    clickedButton.Enabled = false;
                    DisableButton("btnSave");
                    DisableButton("btnUndo");
                    EnableButton("btnPrint");
                    EnableButton("btnRefresh");
                    EnableButton("btnSearch");
                    break;
                case "btnSave":
                    foreach (var button in _buttons.Values)
                    {
                        button.Enabled = true; // Abilita tutti i pulsanti
                    }
                    DisableButton("btnSave");
                    DisableButton("btnUndo");
                    EnableButton("btnPrint");
                    EnableButton("btnRefresh");
                    EnableButton("btnSearch");
                    break;
                case "btnSearch":
                    foreach (var button in _buttons.Values)
                    {
                        button.Enabled = true; // Abilita tutti i pulsanti
                    }
                    DisableButton("btnUndo");
                    DisableButton("btnSave");
                    break;
                case "btnRefresh":
                    foreach (var button in _buttons.Values)
                    {
                        button.Enabled = true; // Abilita tutti i pulsanti
                    }
                    DisableButton("btnUndo");
                    DisableButton("btnSave");
                    break;
                case "btnPrint":
                    foreach (var button in _buttons.Values)
                    {
                        button.Enabled = true; // Abilita tutti i pulsanti
                    }
                    DisableButton("btnUndo");
                    DisableButton("btnSave");
                    break;
                default:
                    foreach (var button in _buttons.Values)
                    {
                        button.Enabled = true; // Abilita tutti i pulsanti
                    }
                    break;
            }
        }

        internal void DisableButton(string buttonName)
        {
            if (_buttons.TryGetValue(buttonName, out ToolStripButton button))
            {
                button.Enabled = false;
            }
        }

        internal void EnableButton(string buttonName)
        {
            if (_buttons.TryGetValue(buttonName, out ToolStripButton button))
            {
                button.Enabled = true;
            }
        }

        internal void DisableAllButtons()
        {
            foreach (var button in _buttons.Values)
            {
                button.Enabled = false;
            }
        }

        internal void EnableAllButtons()
        {
            foreach (var button in _buttons.Values)
            {
                button.Enabled = true;
            }
        }
    }
}
