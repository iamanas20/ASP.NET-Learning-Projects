using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuickTest
{
    public partial class KDNME : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int fontCounter = 9;
            Color color = Color.Aqua;
            for (int i = 0; i < 10; i++)
            {
                var label = new Label();
                fontCounter++;
                label.Font.Size = fontCounter;
                label.Text = "La page dynamique en ASP.NET"; 
                label.Font.Size = GetIncrementedLabelFontSize(label);
                color = GetColor(color);
                label.ForeColor = color;
                Form.Controls.Add(label);
                Form.Controls.Add(new LiteralControl("<br/><br/>"));
            }
        }

        private int GetIncrementedLabelFontSize(Label label) => Convert.ToInt16(label.Font.Size.Unit.Value) + 1;

        private Color GetColor(Color color)
        {
            var R = IncrementColorComponents(color.R, 70);
            var G = IncrementColorComponents(color.G, -10);
            var B = IncrementColorComponents(color.B, -2);
            return Color.FromArgb(255, R, G, B);
        }

        private int IncrementColorComponents(int colorComponent, int incrementValue)
        {
            if ((colorComponent + incrementValue) < 255)
            {
                return colorComponent + incrementValue;
            }
            else
            {
                return colorComponent;
            }
        }


    }
}