using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginAndPasswordValidation
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            string wantedLogin = "iamanas20";
            string wantedPassword = "ILoveNationalAeronauticsAndSpaceAdministrationAkaNASA";

            if (!String.IsNullOrEmpty(LoginTextBox.Text) && LoginTextBox.Text == wantedLogin)
            {
                if (!String.IsNullOrEmpty(PasswordTextBox.Text) && PasswordTextBox.Text == wantedPassword)
                {

                    label.Text = "Bienvenue au site";
                    label.ForeColor = Color.Green;
                }
                else
                {
                    label.Text = "Login ou Mot de passe incorrects";
                    label.ForeColor = Color.Red;
                }
            }
            else
            {
                label.Text = "Login ou Mot de passe incorrects";
                label.ForeColor = Color.Red;
            }

            form1.Controls.Add(label);
        }
    }
}