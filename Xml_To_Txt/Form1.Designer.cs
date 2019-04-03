namespace Xml_To_Txt
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.bt_path = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_rating = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_protocal = new System.Windows.Forms.ComboBox();
            this.tb_page = new System.Windows.Forms.TextBox();
            this.tb_limit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_num = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_url = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_xml = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Txt Path：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Num：";
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(85, 94);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(92, 21);
            this.tb_total.TabIndex = 2;
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(86, 16);
            this.tb_path.Name = "tb_path";
            this.tb_path.ReadOnly = true;
            this.tb_path.Size = new System.Drawing.Size(201, 21);
            this.tb_path.TabIndex = 3;
            // 
            // bt_path
            // 
            this.bt_path.Location = new System.Drawing.Point(293, 14);
            this.bt_path.Name = "bt_path";
            this.bt_path.Size = new System.Drawing.Size(32, 23);
            this.bt_path.TabIndex = 4;
            this.bt_path.Text = "...";
            this.bt_path.UseVisualStyleBackColor = true;
            this.bt_path.Click += new System.EventHandler(this.bt_path_Click);
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(278, 94);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(83, 74);
            this.bt_start.TabIndex = 5;
            this.bt_start.Text = "start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Img Type：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Now Get Num:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(85, 134);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(75, 20);
            this.cb_type.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_rating);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cb_protocal);
            this.panel1.Controls.Add(this.tb_page);
            this.panel1.Controls.Add(this.tb_limit);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_total);
            this.panel1.Controls.Add(this.bt_start);
            this.panel1.Controls.Add(this.cb_type);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_path);
            this.panel1.Controls.Add(this.bt_path);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(63, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 177);
            this.panel1.TabIndex = 11;
            // 
            // cb_rating
            // 
            this.cb_rating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rating.FormattingEnabled = true;
            this.cb_rating.Location = new System.Drawing.Point(219, 134);
            this.cb_rating.Name = "cb_rating";
            this.cb_rating.Size = new System.Drawing.Size(46, 20);
            this.cb_rating.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(166, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 17;
            this.label12.Text = "Rating:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(217, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "Potocal：";
            // 
            // cb_protocal
            // 
            this.cb_protocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_protocal.FormattingEnabled = true;
            this.cb_protocal.Location = new System.Drawing.Point(278, 52);
            this.cb_protocal.Name = "cb_protocal";
            this.cb_protocal.Size = new System.Drawing.Size(60, 20);
            this.cb_protocal.TabIndex = 15;
            // 
            // tb_page
            // 
            this.tb_page.Location = new System.Drawing.Point(153, 51);
            this.tb_page.Name = "tb_page";
            this.tb_page.Size = new System.Drawing.Size(58, 21);
            this.tb_page.TabIndex = 14;
            // 
            // tb_limit
            // 
            this.tb_limit.Location = new System.Drawing.Point(56, 51);
            this.tb_limit.Name = "tb_limit";
            this.tb_limit.Size = new System.Drawing.Size(50, 21);
            this.tb_limit.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "page:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "limit:";
            // 
            // lb_num
            // 
            this.lb_num.AutoSize = true;
            this.lb_num.Location = new System.Drawing.Point(134, 218);
            this.lb_num.Name = "lb_num";
            this.lb_num.Size = new System.Drawing.Size(41, 12);
            this.lb_num.TabIndex = 11;
            this.lb_num.Text = "lb_num";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "Now Img:";
            // 
            // lb_url
            // 
            this.lb_url.AutoEllipsis = true;
            this.lb_url.AutoSize = true;
            this.lb_url.Location = new System.Drawing.Point(119, 244);
            this.lb_url.Name = "lb_url";
            this.lb_url.Size = new System.Drawing.Size(41, 12);
            this.lb_url.TabIndex = 13;
            this.lb_url.Text = "lb_url";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(194, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "xml:";
            // 
            // lb_xml
            // 
            this.lb_xml.AutoSize = true;
            this.lb_xml.Location = new System.Drawing.Point(219, 222);
            this.lb_xml.Name = "lb_xml";
            this.lb_xml.Size = new System.Drawing.Size(41, 12);
            this.lb_xml.TabIndex = 15;
            this.lb_xml.Text = "lb_xml";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 289);
            this.Controls.Add(this.lb_xml);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lb_url);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_num);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button bt_path;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_num;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_url;
        private System.Windows.Forms.TextBox tb_page;
        private System.Windows.Forms.TextBox tb_limit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_xml;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_protocal;
        private System.Windows.Forms.ComboBox cb_rating;
        private System.Windows.Forms.Label label12;
    }
}

