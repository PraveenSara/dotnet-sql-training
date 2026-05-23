using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace ProductsDropdown
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string product = ddlProducts.SelectedValue;

            if (string.IsNullOrEmpty(product))
            {
                lvProducts.DataSource = null;
                lvProducts.DataBind();
                return;
            }

            string folderPath = Server.MapPath("~/ProductsImage/" + product);
            DataTable dt = new DataTable();
            dt.Columns.Add("ImageUrl");

            if (Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath);
                
                foreach (string file in files)
                {
                    string url = "~/ProductsImage/" + product + "/" + Path.GetFileName(file);
                    dt.Rows.Add(url);
                }
            }
            lvProducts.DataSource = dt;
            lvProducts.DataBind();
        }

        protected void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void lvProducts_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "ShowProduct")
            {
                

                lblMessage.Text = "Price : " + "50000";
            }
        }
    }
}