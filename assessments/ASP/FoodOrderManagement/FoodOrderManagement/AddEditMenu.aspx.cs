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
    public partial class AddEditMenu : System.Web.UI.Page
    {
        string conStr = ConfigurationManager.ConnectionStrings["FoodOrder_DB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                if (Request.QueryString["MenuId"] != null)
                {
                    LoadMenuItem();
                }
            }
        }

        private void LoadMenuItem()
        {
            int menuId = Convert.ToInt32(
                Request.QueryString["MenuId"]);

            SqlConnection con = new SqlConnection(conStr);

            string query = "SELECT * FROM MenuItems WHERE MenuId=@MenuId";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@MenuId", menuId);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtItemName.Text = dr["ItemName"].ToString();

                ddlCategory.SelectedValue =  dr["Category"].ToString();

                rblFoodType.SelectedValue = dr["FoodType"].ToString();

                txtPrice.Text = dr["Price"].ToString();

                txtAvailableQuantity.Text = dr["AvailableQuantity"].ToString();

                chkIsAvailable.Checked = Convert.ToBoolean(dr["IsAvailable"]);
            }

            con.Close();
        }

        protected void lblRegister_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["MenuId"] != null)
            {
                UpdateMenuItem();
            }
            else
            {
                InsertMenuItem();
            }
        }

        private void InsertMenuItem()
        {
            SqlConnection con = new SqlConnection(conStr);

            string query = @"INSERT INTO MenuItems
                            (Menuid, ItemName, Category, FoodType,
                             Price, AvailableQuantity,
                             IsAvailable, CreatedDate)

                             VALUES
                            (@MenuId, @ItemName, @Category, @FoodType,
                             @Price, @Qty,
                             @Available, @CreatedDate)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@MenuId",
                txtMenuId.Text);

            cmd.Parameters.AddWithValue("@ItemName",
                txtItemName.Text);

            cmd.Parameters.AddWithValue("@Category",
                ddlCategory.SelectedValue);

            cmd.Parameters.AddWithValue("@FoodType",
                rblFoodType.SelectedValue);

            cmd.Parameters.AddWithValue("@Price",
                Convert.ToDecimal(txtPrice.Text));

            cmd.Parameters.AddWithValue("@Qty",
                Convert.ToInt32(txtAvailableQuantity.Text));

            cmd.Parameters.AddWithValue("@Available",
                chkIsAvailable.Checked);

            cmd.Parameters.AddWithValue("@CreatedDate",
                DateTime.Now);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            lblMessage.Text = "Food item added successfully.";

            ClearControls();
        }

        private void UpdateMenuItem()
        {
            int menuId = Convert.ToInt32(
                Request.QueryString["MenuId"]);

            SqlConnection con = new SqlConnection(conStr);

            string query = @"UPDATE MenuItems
                             SET
                             ItemName=@ItemName,
                             Category=@Category,
                             FoodType=@FoodType,
                             Price=@Price,
                             AvailableQuantity=@Qty,
                             IsAvailable=@Available

                             WHERE MenuId=@MenuId";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ItemName",
                txtItemName.Text);

            cmd.Parameters.AddWithValue("@Category",
                ddlCategory.SelectedValue);

            cmd.Parameters.AddWithValue("@FoodType",
                rblFoodType.SelectedValue);

            cmd.Parameters.AddWithValue("@Price",
                Convert.ToDecimal(txtPrice.Text));

            cmd.Parameters.AddWithValue("@Qty",
                Convert.ToInt32(txtAvailableQuantity.Text));

            cmd.Parameters.AddWithValue("@Available",
                chkIsAvailable.Checked);

            cmd.Parameters.AddWithValue("@MenuId",
                menuId);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            lblMessage.Text = "Food item updated successfully.";
        }

        private void ClearControls()
        {
            txtItemName.Text = "";
            txtPrice.Text = "";
            txtAvailableQuantity.Text = "";

            ddlCategory.SelectedIndex = 0;

            rblFoodType.SelectedIndex = 0;

            chkIsAvailable.Checked = false;
        }

        
    }
}