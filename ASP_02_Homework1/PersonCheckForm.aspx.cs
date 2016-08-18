using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ASP_02_Homework1
{
    public partial class PersonCheckForm : System.Web.UI.Page
    {
        Dictionary<int, string> images = new Dictionary<int, string>();

        protected override void OnPreInit(EventArgs e)
        {
            images.Add(123, "~/Images/Chrysanthemum.jpg");
            images.Add(456, "~/Images/Hydrangeas.jpg");
            images.Add(789, "~/Images/Tulips.jpg");
            base.OnPreInit(e);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            Image1.ImageUrl = RandomValues(images);
        }

        public string RandomValues(Dictionary<int, string> dict)
        {
            List<string> values = Enumerable.ToList(dict.Values);
            Random rand = new Random();
            int randValue = rand.Next(values.Count);
            return values[randValue];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var imageKey = images.FirstOrDefault(x => x.Value == Image1.ImageUrl).Key;
            //var imageKey = images.Where(x => x.Value == Image1.ImageUrl).Select(x => x.Key);
            if (TextBox1.Text == (imageKey).ToString())
            {
                MessageBox.Show("Person is real");
            }
            else
            {
                MessageBox.Show("Person is fake");
            }
        }
    }
}

