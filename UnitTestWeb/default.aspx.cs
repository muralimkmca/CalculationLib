using CalculationLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UnitTestWeb
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNumber1.Text);
            int num2 = Convert.ToInt32(txtNumber2.Text);

            Calculator lib = new Calculator();
            int result = lib.dividingOperation(num1, num2);
            Response.Write("Result value is :" + result);
        }
    }
}