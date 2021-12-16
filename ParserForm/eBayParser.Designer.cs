
namespace EbayParser
{
    partial class Parser_eBay
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.output_button = new System.Windows.Forms.Button();
            this.parse_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.result_label = new System.Windows.Forms.Label();
            this.set_url_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(3, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(670, 387);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 64;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sales";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 98;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Seller";
            this.columnHeader5.Width = 90;
            // 
            // output_button
            // 
            this.output_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output_button.Location = new System.Drawing.Point(708, 56);
            this.output_button.Name = "output_button";
            this.output_button.Size = new System.Drawing.Size(174, 35);
            this.output_button.TabIndex = 1;
            this.output_button.Text = "Output";
            this.output_button.UseVisualStyleBackColor = true;
            this.output_button.Click += new System.EventHandler(this.Output_click);
            // 
            // parse_button
            // 
            this.parse_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parse_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.parse_button.Location = new System.Drawing.Point(65, 423);
            this.parse_button.Name = "parse_button";
            this.parse_button.Size = new System.Drawing.Size(773, 35);
            this.parse_button.TabIndex = 2;
            this.parse_button.Text = "Parse";
            this.parse_button.UseVisualStyleBackColor = true;
            this.parse_button.Click += new System.EventHandler(this.Add_Click);
            // 
            // del_button
            // 
            this.del_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_button.Location = new System.Drawing.Point(708, 126);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(174, 35);
            this.del_button.TabIndex = 3;
            this.del_button.Text = "Delete All";
            this.del_button.UseVisualStyleBackColor = true;
            this.del_button.Click += new System.EventHandler(this.Delete_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar1.Location = new System.Drawing.Point(65, 477);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(773, 32);
            this.progressBar1.TabIndex = 4;
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.result_label.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.result_label.Location = new System.Drawing.Point(733, 515);
            this.result_label.Margin = new System.Windows.Forms.Padding(3);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(105, 32);
            this.result_label.TabIndex = 5;
            this.result_label.Text = "Success";
            this.result_label.Visible = false;
            // 
            // set_url_box
            // 
            this.set_url_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.set_url_box.Location = new System.Drawing.Point(708, 214);
            this.set_url_box.MaximumSize = new System.Drawing.Size(174, 35);
            this.set_url_box.MinimumSize = new System.Drawing.Size(174, 35);
            this.set_url_box.Multiline = true;
            this.set_url_box.Name = "set_url_box";
            this.set_url_box.Size = new System.Drawing.Size(174, 35);
            this.set_url_box.TabIndex = 6;
            this.set_url_box.Text = "https://www.ebay.com/b/Cell-Phones-Smartphones/9355/bn_320094";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(704, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Set URL from eBay:";
            // 
            // Parser_eBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.set_url_box);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.parse_button);
            this.Controls.Add(this.output_button);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(950, 600);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Parser_eBay";
            this.ShowIcon = false;
            this.Text = "Parser_eBay";
            this.Load += new System.EventHandler(this.Parser_eBay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button output_button;
        private System.Windows.Forms.Button parse_button;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.TextBox set_url_box;
        private System.Windows.Forms.Label label2;
    }
}

