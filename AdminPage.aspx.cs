using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_with_Master_Page
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //GridView grid_data = this.Master.FindControl("Content1") as GridView;

            //grid_data.DataSource = GetData();
            //grid_data.DataBind();

        }
        public IQueryable<ProductDTO> GetData()
        {
            var products = new List<ProductDTO>()

                {
                    new ProductDTO { Title = "Mobile", Category = "Digital", QuantityPerUnit = 100 },
                    new ProductDTO { Title = "TV", Category = "Digital", QuantityPerUnit = 200 }
                };
            
            //{ Title = "Mobile", Category = "Digital", QuantityPerUnit = 100 };
            return  products.AsQueryable();
        }
    }
}