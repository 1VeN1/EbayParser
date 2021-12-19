using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EbayParser
{
    public partial class Parser_eBay : Form
    {

        public Parser_eBay()
        {
            InitializeComponent();
        }



        private void Output_click(object sender, EventArgs e)
        {


            using (ProductContext context = new ProductContext())
            {

                foreach (Products product in context.Product)
                {
                    Sellers seller = product.Sellers;
                    var item = new ListViewItem(product.ID.ToString());
                    item.SubItems.Add(product.Name);
                    item.SubItems.Add(product.Price);
                    item.SubItems.Add(product.Sales);
                    item.SubItems.Add(seller.Nickname);
                    listView1.Items.Add(item);
                }
                var exc = context.Product.FirstOrDefault(x => x.ID == 1);
                if (exc == null)
                    MessageBox.Show("Plese Parse Data", "Error", MessageBoxButtons.OK);
            }


        }


        private void Add_Click(object sender, EventArgs e)
        {
            set_url_box.Enabled = false;
            output_button.Enabled = false;
            del_button.Enabled = false;
            parse_button.ForeColor = Color.Black;
            Parser.ToParse(progressBar1, result_label, output_button, del_button, set_url_box);
            parse_button.Enabled = false;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Parser.DeleteAllInDb();
            listView1.Items.Clear();
            parse_button.ForeColor = Color.Black;
            parse_button.Enabled = true;
            progressBar1.Value = 0;
            result_label.Visible = false;
        }

        private void Parser_eBay_Load(object sender, EventArgs e)
        {
            using (ProductContext context = new ProductContext())
            {
                listView1.Items[0].Remove();
                Products product = context.Product.FirstOrDefault(x => x.ID == 1);
                _ = product != null ? parse_button.Enabled = false : parse_button.Enabled = true;
            }
        }
    }
}
