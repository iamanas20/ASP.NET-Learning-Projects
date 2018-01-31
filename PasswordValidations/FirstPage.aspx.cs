using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PasswordValidations
{
    public partial class FirstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs args)
        {
            //var label = new Label();

            //if (CheckValidation(myPassword.Text, "ILoveNASA") && CheckValidation(myLogin.Text, "iamanas20"))
            //{
            //    label.Text = "Succes";
            //}
            //else
            //{
            //    label.Text = "Echoue";
            //}

            //form1.Controls.Add(label);
        }

        private bool CheckValidation(string givenPassword, string password) => givenPassword == password;


    }
}