using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_Management_System
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"].Equals(""))
                {
                    LinkButton1.Visible = true; // user login link button
                    LinkButton2.Visible = true; // sign up link button
                    LinkButton4.Visible = true; // view books button
                    LinkButton5.Visible = true; // adminlogin button

                    LinkButton3.Visible = false; // logout link button
                    LinkButton7.Visible = false; // hello user link button
                    LinkButton15.Visible = false;
                    LinkButton16.Visible = false;
                    LinkButton17.Visible = false;
                }
                else if (Session["role"].Equals("user"))
                {

                    LinkButton1.Visible = false; // user login link button
                    LinkButton2.Visible = false; // sign up link button
                    LinkButton4.Visible = true; // view books button
                    LinkButton5.Visible = true; // adminlogin button

                    LinkButton3.Visible = true; // logout link button
                    LinkButton7.Visible = true; // hello user link button
                    LinkButton15.Visible = false;
                    LinkButton16.Visible = false;
                    LinkButton17.Visible = false;
                    LinkButton7.Text = "Hello, " + Session["fullname"].ToString();
                }
                else if (Session["role"].Equals("admin"))
                {

                    LinkButton1.Visible = false; // user login link button
                    LinkButton2.Visible = false; // sign up link button
                    LinkButton4.Visible = true; // view books button
                    LinkButton5.Visible = false; // adminlogin button

                    LinkButton3.Visible = true; // logout link button
                    LinkButton7.Visible = true; // hello user link button
                    LinkButton15.Visible = true;
                    LinkButton16.Visible = true;
                    LinkButton17.Visible = true;
                    LinkButton7.Text = "Hello, Admin";
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            //object Response = null;
            Response.Redirect("AdminLogIn.aspx");
        }

        protected void LinkButton15_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookInventory.aspx");
        }

        protected void LinkButton16_Click(object sender, EventArgs e)
        {
            Response.Redirect("IssueBook.aspx");
        }

        protected void LinkButton17_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberManagement.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewBooks.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserLogIn.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserSignUp.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserProfile.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";


            LinkButton1.Visible = true; // user login link button
            LinkButton2.Visible = true; // sign up link button
            LinkButton4.Visible = true; // view books button
            LinkButton5.Visible = true; // adminlogin button

            LinkButton3.Visible = false; // logout link button
            LinkButton7.Visible = false; // hello user link button
            LinkButton15.Visible = false;
            LinkButton16.Visible = false;
            LinkButton17.Visible = false;

            Response.Redirect("Home.aspx");
        }
    }
}