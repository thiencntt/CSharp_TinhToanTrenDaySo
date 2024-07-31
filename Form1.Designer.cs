namespace CSharp_TinhToanTrenDaySo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            txtStartNum = new TextBox();
            txtEndNum = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtTotal = new TextBox();
            txtPower = new TextBox();
            txtTotalChan = new TextBox();
            txtTotalLe = new TextBox();
            btnTinhToan = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 9);
            label1.Name = "label1";
            label1.Size = new Size(232, 23);
            label1.TabIndex = 0;
            label1.Text = "TÍNH TOÁN TRÊN DÃY SỐ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(175, 23);
            label2.TabIndex = 1;
            label2.Text = "Giới hạn của dãy số";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(456, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(443, 244);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(193, 42);
            label3.Name = "label3";
            label3.Size = new Size(102, 23);
            label3.TabIndex = 1;
            label3.Text = "Số bắt đầu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(372, 42);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 1;
            label4.Text = "Số kết thúc";
            // 
            // txtStartNum
            // 
            txtStartNum.Location = new Point(301, 39);
            txtStartNum.Name = "txtStartNum";
            txtStartNum.Size = new Size(65, 30);
            txtStartNum.TabIndex = 3;
            // 
            // txtEndNum
            // 
            txtEndNum.Location = new Point(483, 39);
            txtEndNum.Name = "txtEndNum";
            txtEndNum.Size = new Size(65, 30);
            txtEndNum.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Coral;
            label5.Location = new Point(12, 84);
            label5.Name = "label5";
            label5.Size = new Size(75, 23);
            label5.TabIndex = 1;
            label5.Text = "Kết quả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 130);
            label6.Name = "label6";
            label6.Size = new Size(111, 23);
            label6.TabIndex = 1;
            label6.Text = "Tổng các số";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 173);
            label7.Name = "label7";
            label7.Size = new Size(103, 23);
            label7.TabIndex = 1;
            label7.Text = "Tích các số";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 216);
            label8.Name = "label8";
            label8.Size = new Size(158, 23);
            label8.TabIndex = 1;
            label8.Text = "Tổng các số chẵn";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 259);
            label9.Name = "label9";
            label9.Size = new Size(131, 23);
            label9.TabIndex = 1;
            label9.Text = "Tổng các số lẻ";
            // 
            // txtTotal
            // 
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Location = new Point(184, 127);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(231, 30);
            txtTotal.TabIndex = 3;
            // 
            // txtPower
            // 
            txtPower.BorderStyle = BorderStyle.FixedSingle;
            txtPower.Location = new Point(184, 170);
            txtPower.Name = "txtPower";
            txtPower.ReadOnly = true;
            txtPower.Size = new Size(231, 30);
            txtPower.TabIndex = 3;
            // 
            // txtTotalChan
            // 
            txtTotalChan.BorderStyle = BorderStyle.FixedSingle;
            txtTotalChan.Location = new Point(184, 213);
            txtTotalChan.Name = "txtTotalChan";
            txtTotalChan.ReadOnly = true;
            txtTotalChan.Size = new Size(231, 30);
            txtTotalChan.TabIndex = 3;
            // 
            // txtTotalLe
            // 
            txtTotalLe.BorderStyle = BorderStyle.FixedSingle;
            txtTotalLe.Location = new Point(184, 256);
            txtTotalLe.Name = "txtTotalLe";
            txtTotalLe.ReadOnly = true;
            txtTotalLe.Size = new Size(231, 30);
            txtTotalLe.TabIndex = 3;
            // 
            // btnTinhToan
            // 
            btnTinhToan.FlatStyle = FlatStyle.Flat;
            btnTinhToan.Location = new Point(140, 314);
            btnTinhToan.Name = "btnTinhToan";
            btnTinhToan.Size = new Size(176, 64);
            btnTinhToan.TabIndex = 4;
            btnTinhToan.Text = "Tính toán";
            btnTinhToan.UseVisualStyleBackColor = true;
            btnTinhToan.Click += btnTinhToan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 456);
            Controls.Add(btnTinhToan);
            Controls.Add(txtEndNum);
            Controls.Add(txtTotalLe);
            Controls.Add(txtTotalChan);
            Controls.Add(txtPower);
            Controls.Add(txtTotal);
            Controls.Add(txtStartNum);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 14F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private TextBox txtStartNum;
        private TextBox txtEndNum;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtTotal;
        private TextBox txtPower;
        private TextBox txtTotalChan;
        private TextBox txtTotalLe;
        private Button btnTinhToan;
    }
}
