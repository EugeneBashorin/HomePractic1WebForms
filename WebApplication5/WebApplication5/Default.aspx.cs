using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Click += Button1_Click;
            Button2.Click += Button2_Click;
            Button3.Click += Button3_Click;
            Button4.Click += Button4_Click;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ViewState["data"] = (Convert.ToInt32(Button2.Text) + 1);
            Button2.Text = ViewState["data"].ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["data"] = (Convert.ToInt32(Button3.Text) + 1);
            Button3.Text = Session["data"].ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Result.Text = PageEventsAndManageElements.QuadraticEquation(TextBox1.Text, TextBox2.Text, TextBox3.Text);
        }
    }
}
/* #1
Глобальные события приложения
Напишите обработчики, которые записывают в файл время начала любой сессии и время окончания данной сессии.
   #2
Создайте Web-страницу с одной кнопкой. Изначально на кнопке должно изображаться число ноль. По клику на данную копку, число должно 
увеличиваться на единицу. Необходимо использовать возможности сохранения состояния.
Реализуйте 2 версии текущего задания, используя следующие объекты:
1. ViewState;
2. Session.
   #3
   Решить квадратное уравнение ax2 + bx + c = 0
*/
