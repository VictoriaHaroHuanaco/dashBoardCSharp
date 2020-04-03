using System;
using WForms = System.Windows.Forms;

namespace DashBoard.View
{
    public partial class BaseMetro : MetroFramework.Forms.MetroForm
    {
        private readonly int magic =
            Convert.ToInt32(WForms.Keys.Control)
            + Convert.ToInt32(WForms.Keys.Shift)
            + Convert.ToInt32(WForms.Keys.F9)
            ;

        public BaseMetro()
        {
            Icon = System.Drawing.Icon.FromHandle(Properties.Resources._superman.GetHicon());
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref WForms.Message msg, WForms.Keys keyData)
        {
            if (magic.Equals(Convert.ToInt32(keyData)))
            {
                WForms.MessageBox.Show(ToString());
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}