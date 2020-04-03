using System;
using System.Drawing;
using System.Windows.Forms;

namespace DashBoard.View
{
    public partial class LoadingScreen : Form
    {
        private static LoadingScreen loadignForm;
        private static bool EnableParent { get; set; }
        public static Form Myform { get; set; }

        internal static bool IsVisible
        {
            get
            {
                return loadignForm != null && !loadignForm.IsDisposed && loadignForm.Visible;
            }
        }

        public LoadingScreen()
        {
            InitializeComponent();
        }

        internal static void BeginInvoke(Action action)
        {
            if (loadignForm != null && !loadignForm.IsDisposed)
            {
                Delegate del = action;
                loadignForm.BeginInvoke(del);
            }
        }

        internal static void BeginInvoke(Action<string[]> action)
        {
            if (loadignForm != null && !loadignForm.IsDisposed)
            {
                Delegate del = action;
                loadignForm.BeginInvoke(del);
            }
        }

        public static void ShowLoading(Form f, bool disableme = true)
        {
            int Fx = f.Location.X;
            int Fy = f.Location.Y;
            if (loadignForm == null || loadignForm.IsDisposed)
            {
                loadignForm = new LoadingScreen();
            }
            loadignForm.Show();
            loadignForm.BringToFront();
            if (f != null)
            {
                loadignForm.Location = new Point(
                        ((f.Width - loadignForm.Width) / 2) + Fx
                        ,
                        ((f.Height - loadignForm.Height) / 2) + Fy
                        );
            }
            if ((EnableParent = disableme))
            {
                f.Enabled = false;
                Myform = f;
            }
            else
            {
                Myform = null;
            }
        }

        public static void CloseLoading()
        {
            if (loadignForm != null && !loadignForm.IsDisposed && loadignForm.Visible)
            {
                BeginInvoke(() => loadignForm.Hide());
            }
            if (EnableParent && Myform != null)
            {
                Myform.Enabled = true;
                Myform.BringToFront();
            }
        }
    }
}