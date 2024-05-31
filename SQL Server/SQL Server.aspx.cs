using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace SQL_Server
{
    public partial class SQL_Server : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("data source=SAHIL\\SQLEXPRESS; initial catalog=school; integrated security=true;");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtName.Focus();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into students(name,address) values('" + txtName.Text + "','" + txtAddress.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            txtName.Text = "";
            txtAddress.Text = "";
            lblMessage.Text = "Successfully Register!";
        }
    }
}