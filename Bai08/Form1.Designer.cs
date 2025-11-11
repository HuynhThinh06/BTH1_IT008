namespace Bai08
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTaikhoan = new System.Windows.Forms.TextBox();
            this.tbHoten = new System.Windows.Forms.TextBox();
            this.tbDiachi = new System.Windows.Forms.TextBox();
            this.tbSotien = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MTK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbTT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tiền trong tài khoản";
            // 
            // tbTaikhoan
            // 
            this.tbTaikhoan.Location = new System.Drawing.Point(223, 12);
            this.tbTaikhoan.Name = "tbTaikhoan";
            this.tbTaikhoan.Size = new System.Drawing.Size(299, 22);
            this.tbTaikhoan.TabIndex = 4;
            // 
            // tbHoten
            // 
            this.tbHoten.Location = new System.Drawing.Point(223, 41);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(299, 22);
            this.tbHoten.TabIndex = 5;
            // 
            // tbDiachi
            // 
            this.tbDiachi.Location = new System.Drawing.Point(223, 69);
            this.tbDiachi.Name = "tbDiachi";
            this.tbDiachi.Size = new System.Drawing.Size(299, 22);
            this.tbDiachi.TabIndex = 6;
            // 
            // tbSotien
            // 
            this.tbSotien.Location = new System.Drawing.Point(223, 97);
            this.tbSotien.Name = "tbSotien";
            this.tbSotien.Size = new System.Drawing.Size(299, 22);
            this.tbSotien.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.MTK,
            this.TenKH,
            this.DC,
            this.SoTien});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(63, 175);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(662, 248);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 50;
            // 
            // MTK
            // 
            this.MTK.Text = "Mã tài khoản";
            this.MTK.Width = 115;
            // 
            // TenKH
            // 
            this.TenKH.Text = "Tên khách hàng";
            this.TenKH.Width = 113;
            // 
            // DC
            // 
            this.DC.Text = "Địa chỉ";
            this.DC.Width = 112;
            // 
            // SoTien
            // 
            this.SoTien.Text = "Số tiền";
            this.SoTien.Width = 108;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm/Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(447, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(540, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 11;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbTT
            // 
            this.tbTT.Location = new System.Drawing.Point(573, 440);
            this.tbTT.Name = "tbTT";
            this.tbTT.Size = new System.Drawing.Size(152, 22);
            this.tbTT.TabIndex = 12;
            this.tbTT.Text = "0";
            this.tbTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tổng tiền";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 486);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTT);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbSotien);
            this.Controls.Add(this.tbDiachi);
            this.Controls.Add(this.tbHoten);
            this.Controls.Add(this.tbTaikhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTaikhoan;
        private System.Windows.Forms.TextBox tbHoten;
        private System.Windows.Forms.TextBox tbDiachi;
        private System.Windows.Forms.TextBox tbSotien;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader MTK;
        private System.Windows.Forms.ColumnHeader TenKH;
        private System.Windows.Forms.ColumnHeader DC;
        private System.Windows.Forms.ColumnHeader SoTien;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbTT;
        private System.Windows.Forms.Label label5;
    }
}

