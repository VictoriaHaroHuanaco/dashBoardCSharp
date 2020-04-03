using DashBoard.Constantes;
using DashBoard.Controller;
using MetroFramework;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DashBoard.View
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        #region controladores

        private LoginController loginC = new LoginController();

        #endregion controladores

        public bool ExitApp { get; set; } = true;

        public LoginForm()
        {
            Icon = System.Drawing.Icon.FromHandle(Properties.Resources._superman.GetHicon());
            InitializeComponent();
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Close();
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ExitApp)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            Byte[] bytesOriginales = Encoding.Default.GetBytes(txtPassword.Text);
            Byte[] bytesCodificados = md5.ComputeHash(bytesOriginales);
            String passmd5 = BitConverter.ToString(bytesCodificados).Replace("-", "");

            try
            {
                bool permisoIngresar = loginC.IngresaLogin(txtApplicationName.Text, passmd5.ToLower());

                if (!permisoIngresar)
                {
                    MetroMessageBox.Show(this, constMensajes.WrongLoginData, constMensajes.Error, MessageBoxButtons.OK, MessageBoxIcon.Error, 120);
                    return;
                }
                ExitApp = false;
                MenuForm f = new MenuForm();
                f.Show();
                Close();
            }
            catch (Exception ex)
            {
                RegistrarErrorController.RegistrarError("LoginForm.cs", "btnLogin_Click", ex);
                MetroMessageBox.Show(this, constMensajes.SqlExceptionDetected, constMensajes.Error, MessageBoxButtons.OK, MessageBoxIcon.Error, 120);
            }
        }
    }
}