using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodOrderManagement
{
    public partial class MenuDetails : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["FoodOrder_DB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (Request.QueryString["MenuId"] != null)
            {
                if (!IsPostBack)
                {
                    LoadMenuDetails();
                }
            }
            else
            {
                Response.Redirect("MenuList.aspx");
            }
        }
        private void LoadMenuDetails()
        {
            int menuId = Convert.ToInt32(
                Request.QueryString["MenuId"]);

            SqlConnection con = new SqlConnection(cs);

            string query = "SELECT * FROM MenuItems WHERE MenuId=@MenuId";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@MenuId", menuId);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lblMenuId.Text = dr["MenuId"].ToString();

                lblItemName.Text = dr["ItemName"].ToString();

                lblCategory.Text = dr["Category"].ToString();

                lblFoodType.Text = dr["FoodType"].ToString();

                lblPrice.Text = dr["Price"].ToString();

                lblQuantity.Text = dr["AvailableQuantity"].ToString();

                bool available = Convert.ToBoolean(dr["IsAvailable"]);

                lblAvailable.Text = available ? "Available" : "Not Available";

                lblCreatedDate.Text = Convert.ToDateTime(dr["CreatedDate"]).ToString("dd-MM-yyyy");
            }

            con.Close();
        }
    }
}