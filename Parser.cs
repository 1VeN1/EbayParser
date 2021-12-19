using HtmlAgilityPack;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;


namespace EbayParser
{

    public class Parser
    {
        private const int k = 1;
        private static string seller_xpath;

        public static void ToParse(ProgressBar progressbar, Label result, Button output_button, Button del_button, TextBox indicated_url)
        {
            try
            {

                using (ProductContext context = new ProductContext())
                {
                    HtmlWeb webDoc = new HtmlWeb();
                    HtmlAgilityPack.HtmlDocument doc = webDoc.Load(indicated_url.Text);
                    HtmlNodeCollection href = doc.DocumentNode.SelectNodes("//div[@class='s-item__info clearfix']");
                    for (int i = 0; i != href.Count; i++)
                    {

                        var product = doc.DocumentNode.SelectNodes("//div[@class='s-item__info clearfix']");
                        var price = doc.DocumentNode.SelectNodes("//span[@class='s-item__price']");
                        var sold = doc.DocumentNode.SelectNodes("//span[@class='NEGATIVE']");
                        var product_link = href[i].FirstChild.GetAttributeValue("href", "");


                        HtmlWeb webDoc_2 = new HtmlWeb();
                        HtmlAgilityPack.HtmlDocument doc_2 = webDoc.Load(product_link);
                        
                        var products_seller = doc_2.DocumentNode.SelectNodes(seller_xpath = "//span[@class='mbg-nw']") ?? doc_2.DocumentNode.SelectNodes(seller_xpath = "//div[contains(@class,'seller-persona')]");

                        if (seller_xpath == "//div[contains(@class,'seller-persona')]")
                        {
                            string name = products_seller[0].ChildNodes[1].ChildNodes[0].InnerText;
                            Sellers sellers = new Sellers
                            {

                                Nickname = name


                            };
                            context.Sellers.Add(sellers);
                            context.SaveChanges();
                        }
                        else if (seller_xpath == "//span[@class='mbg-nw']")
                        {

                            Sellers sellers = new Sellers
                            {
                                Nickname = products_seller[0].InnerText,


                            };
                            context.Sellers.Add(sellers);
                            context.SaveChanges();
                        }

                        string value_sale = i >= sold.Count ? "0" : sold[i].ChildNodes[0].InnerText;

                        Products product_data = new Products
                        {
                            Name = product[i].FirstChild.LastChild.InnerText,
                            Price = price[i].LastChild.InnerText,
                            Sales = value_sale.Replace("sold", "").Replace("watching", ""),
                            SellerID = i + k

                        };
                        context.Product.Add(product_data);
                        context.SaveChanges();


                        if (i != href.Count)
                        {

                            progressbar.Value++;

                        }
                        if (progressbar.Value == href.Count)
                        {
                            progressbar.Value = 100;
                            result.Visible = true;
                            output_button.Enabled = true;
                            del_button.Enabled = true;
                            indicated_url.Enabled = true;
                        }

                    }
                }
            }
            catch (IOException e)
            {
                if (e.Source != null)
                {
                    progressbar.Value = 100;
                    result.Text = "Connection failed";
                    result.ForeColor = System.Drawing.Color.Orange;
                    result.Visible = true;
                    output_button.Enabled = true;
                    del_button.Enabled = true;
                    indicated_url.Enabled = true;

                }
            }
            catch (Exception)
            {
                progressbar.Value = 100;
                result.Text = "Error";
                result.ForeColor = System.Drawing.Color.Red;
                result.Visible = true;
                output_button.Enabled = true;
                del_button.Enabled = true;
                indicated_url.Enabled = true;
            }


        }

        static public void DeleteAllInDb()
        {
            using (ProductContext context = new ProductContext())
            {
                context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Product', RESEED, 0)");
                var products_table = context.Product.Where(x => x.ID >= 1).ToList();
                context.Product.RemoveRange(products_table);
                context.SaveChanges();

                context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Sellers', RESEED, 0)");
                var sellers_table = context.Sellers.Where(x => x.ID >= 1).ToList();
                context.Sellers.RemoveRange(sellers_table);
                context.SaveChanges();
            };

        }




    }
}
