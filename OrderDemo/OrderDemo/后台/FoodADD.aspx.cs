using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrderDemo.后台
{
    public partial class FoodADD : System.Web.UI.Page
    {
       static string n;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFiles)
            {
                string fliename = FileUpload1.FileName;
                string filetype = fliename.Substring(fliename.LastIndexOf('.') + 1).ToLower();
                if (filetype == "jpg" || filetype == "png")
                {
                   FileUpload1.SaveAs(Server.MapPath("..\\img\\" + FileUpload1.FileName));
                   /* FileUpload1.SaveAs(Server.MapPath("..\\img" + FileUpload1.FileName));*/
                    
                    
                    this.Image1.ImageUrl = "..\\img\\" + fliename;
                    n = fliename;
                }
            }
            else
            {
                Label5.Text = "文件格式不正确";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            food.FoodName = this.TextBox5.Text.Trim();
            food.FoodTypeID = int.Parse(this.DropDownList1.SelectedValue.ToString());
            food.Price = decimal.Parse(this.textbox2.Text.Trim());
            food.PicUrl = "..\\img\\" + n;
            food.AddDate = DateTime.Now.ToLocalTime();
            
            food.Desc = this.textbox4.Text.Trim();
            if (FoodManager.Add(food))
            {
                Response.Write("<script>alert('保存成功!')</script>");
            }
            else
            {
                Response.Write("<script>alert('保存失败!')</script>");
            }
        }
    }
}