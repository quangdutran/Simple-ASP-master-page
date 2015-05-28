using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Entity.Validation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Drawing.Imaging;

public partial class MasterPage : System.Web.UI.MasterPage
{

    private DataClassesDataContext objcon = new DataClassesDataContext();


    protected void Page_Load(object sender, EventArgs e)
    {
        //Display information in the About section
        var path = from o in objcon.Abouts
                   where o.id == 1
                   select o;
        foreach (var detail in path)
        {
            Img1.ImageUrl = detail.img;
            NameT.InnerText = detail.name;
            ClassT.InnerText = detail.@class;
            InterestT.InnerText = detail.information;
        }

        var path1 = from o in objcon.Abouts
                    where o.id == 2
                    select o;
        foreach (var detail in path1)
        {
            Image2.ImageUrl = detail.img;
            NameD.InnerText = detail.name;
            ClassD.InnerText = detail.@class;
            InterestD.InnerText = detail.information;
        }

        //Display information at the Portfolio section (Portfolio Modal 6)
        var path2 = from o in objcon.Portfolios
                    where o.id == 3
                    select o;
        foreach (var detail in path2)
        {
            //Home Page
            ImagePr6.ImageUrl = detail.imageS;
            ProjectName6S.InnerText = detail.projectName;

            //Detail Page
            ImagePr6L.ImageUrl = detail.imageL;
            ProjectName6.InnerText = detail.projectName;
            BriefDescription6.InnerText = detail.briefDescription;
            Pr6Detail.InnerText = detail.detail;
        }

        //Display information at the Portfolio section (Portfolio Modal 5)
        var path3 = from o in objcon.Portfolios
                    where o.id == 2
                    select o;
        foreach (var detail in path3)
        {
            //Home Page
            ImagePr5.ImageUrl = detail.imageS;
            ProjectName5S.InnerText = detail.projectName;

            //Detail Page
            ImagePr5L.ImageUrl = detail.imageL;
            ProjectName5.InnerText = detail.projectName;
            BriefDescription5.InnerText = detail.briefDescription;
            Pr5Detail.InnerText = detail.detail;
        }

        //Display information at the Portfolio section (Portfolio Modal 4)
        var path4 = from o in objcon.Portfolios
                    where o.id == 1
                    select o;
        foreach (var detail in path4)
        {
            //Home Page
            ImagePr4.ImageUrl = detail.imageS;
            ProjectName4S.InnerText = detail.projectName;

            //Detail Page
            ImagePr4L.ImageUrl = detail.imageL;
            ProjectName4.InnerText = detail.projectName;
            BriefDescription4.InnerText = detail.briefDescription;
            Pr4Detail.InnerText = detail.detail;
        }

        //if (!IsPostBack)
        //{
        //    FillCapctha();
        //}
    }

    protected void send_Click(object sender, EventArgs e)
    {

        //if (Session["captcha"].ToString() != txtCaptcha.Text)
        //    Response.Write("Invalid Captcha Code");
        //else
        //    Response.Write("Valid Captcha Code");
        //FillCapctha();
       
            if (Page.IsValid)
            {
                Contact contact = new Contact();
                contact.name = name.Text;
                contact.email = email.Text;
                contact.phone = Convert.ToInt32(phone.Text);
                contact.message = message.Text;
                objcon.Contacts.InsertOnSubmit(contact);
                objcon.SubmitChanges();

                name.Text = "";
                email.Text = "";
                phone.Text = "";
                message.Text = "";

            }
      
    }

    //void FillCapctha()
    //{
    //    try
    //    {
    //        //Random random = new Random();
    //        //string combination = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    //        //StringBuilder captcha = new StringBuilder();
    //        //for (int i = 0; i < 6; i++)
    //        //    captcha.Append(combination[random.Next(combination.Length)]);
    //        //Session["captcha"] = captcha.ToString();
    //        //imgCaptcha.ImageUrl = "Captcha.aspx?" + DateTime.Now.Ticks.ToString();
    //    }
    //    catch
    //    {

    //        throw;
    //    }
    //}

    //protected void btnRefresh_Click(object sender, EventArgs e)
    //{
    //    FillCapctha();
    //}

    //protected void btnRegister_Click(object sender, EventArgs e)
    //{
    //    if (Session["captcha"].ToString() != txtCaptcha.Text)
    //        Response.Write("Invalid Captcha Code");
    //    else
    //        Response.Write("Valid Captcha Code");
    //    FillCapctha();
    //}


}
