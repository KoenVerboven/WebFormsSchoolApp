using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsSchoolApp.SchoolDepartment
{
    public partial class WebFormSchoolClassOrganistation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("../StartPage.aspx");
            }
           
            if(!Page.IsPostBack)
            {
                ListItem listItem = new ListItem();
                listItem.Value = "1";
                listItem.Text = "koen verboven";
                ListBox1.Items.Add(listItem);

                ListItem listItem2 = new ListItem();
                listItem2.Value = "2";
                listItem2.Text = "maria poels";
                ListBox1.Items.Add(listItem2);

                ListItem listItem3 = new ListItem();
                listItem3.Value = "3";
                listItem3.Text = "Paul Janssens";
                ListBox1.Items.Add(listItem3);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem =  ListBox1.SelectedItem;
                ListBox2.Items.Add(selectedItem);
                ListBox1.Items.Remove(selectedItem);
                ListBox1.ClearSelection();
                ListBox2.ClearSelection();
            }
            catch (Exception oEx)
            {
                var message = oEx.Message;
                throw;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = ListBox2.SelectedItem;
                ListBox1.Items.Add(selectedItem);
                ListBox2.Items.Remove(selectedItem);
                ListBox2.ClearSelection();
                ListBox1.ClearSelection();
            }
            catch (Exception oEx)
            {
                var message = oEx.Message;
                throw;
            }
        }
    }
}