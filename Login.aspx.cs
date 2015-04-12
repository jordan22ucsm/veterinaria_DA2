using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Login : System.Web.UI.Page

   

{

    string User = "admin", pass = "1234";

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {



        if (TextBox1.Text == User && TextBox2.Text == pass) 
        {
            Usuario.Text = "Bienvenido " + User;
        }
        TextBox1.Visible = false;
        TextBox2.Visible = false;
        Label1.Visible = false;
        Label2.Visible = false;

       
/*
        Session.Add("Usuario", User);
        Server.Transfer("Default.aspx");
        Server.Transfer("Medicos.aspx");
        Server.Transfer("Petshop.aspx");
        Server.Transfer("Login.aspx");
        Server.Transfer("Nosotros.aspx");
        */
        //Response.Redirect("PetShop.aspx");




    }
}