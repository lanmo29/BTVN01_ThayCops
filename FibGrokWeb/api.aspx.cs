using System;
using System.Web;
using FibGrokLib;

namespace FibGrokWeb
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nStr = Request.Form["n"];
            int n;
            if (int.TryParse(nStr, out n) && n >= 0)
            {
                FibonacciCalculator calc = new FibonacciCalculator();
                calc.Position = n;
                calc.Calculate();
                Response.Clear();
                Response.ContentType = "application/json";
                Response.Write("{ \"result\": \"" + calc.Result.Replace("\"", "\\\"") + "\" }");
                Response.End();
            }
            else
            {
                Response.Clear();
                Response.ContentType = "application/json";
                Response.Write("{ \"result\": \"Invalid input! - HungLanBTVN\" }");
                Response.End();
            }
        }
    }
}