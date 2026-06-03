using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodOrderManagement
{

    public partial class MenuList : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["FoodOrder_DB"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {
                LoadMenuItems();
            }
        }

        private void LoadMenuItems()
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "SELECT * FROM MenuItems";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender,
            System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            int menuId = Convert.ToInt32(
                GridView1.DataKeys[index].Value);

            if (e.CommandName == "ViewItem")
            {
                Response.Redirect(
                    "MenuDetails.aspx?MenuId=" + menuId);
            }

            else if (e.CommandName == "EditItem")
            {
                Response.Redirect(
                    "AddEditMenu.aspx?MenuId=" + menuId);
            }

            else if (e.CommandName == "DeleteItem")
            {
                DeleteMenu(menuId);
                LoadMenuItems(); 
            }
        }

        private void DeleteMenu(int menuId)
        {
            SqlConnection con = new SqlConnection(cs);

            string query =
                "DELETE FROM MenuItems WHERE MenuId=@MenuId";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@MenuId", menuId);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddEditMenu.aspx");
        }
    }
}