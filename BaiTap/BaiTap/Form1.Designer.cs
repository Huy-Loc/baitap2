
namespace BaiTap
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
            this.Btn_Nhap = new System.Windows.Forms.Button();
            this.Bn_Tiep = new System.Windows.Forms.Button();
            this.Btn_Thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Nhap = new System.Windows.Forms.Label();
            this.Lbl_Dayvuanhap = new System.Windows.Forms.Label();
            this.Lbl_Tong = new System.Windows.Forms.Label();
            this.Lbl_TC = new System.Windows.Forms.Label();
            this.Lbl_TL = new System.Windows.Forms.Label();
            this.Txt_Nhap = new System.Windows.Forms.TextBox();
            this.Txt_Dayvuanhap = new System.Windows.Forms.TextBox();
            this.Txt_Tong = new System.Windows.Forms.TextBox();
            this.Txt_TC = new System.Windows.Forms.TextBox();
            this.Txt_TL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Nhap
            // 
            this.Btn_Nhap.AutoSize = true;
            this.Btn_Nhap.Location = new System.Drawing.Point(251, 79);
            this.Btn_Nhap.Name = "Btn_Nhap";
            this.Btn_Nhap.Size = new System.Drawing.Size(81, 30);
            this.Btn_Nhap.TabIndex = 0;
            this.Btn_Nhap.Text = "Nhập";
            this.Btn_Nhap.UseVisualStyleBackColor = true;
            this.Btn_Nhap.Click += new System.EventHandler(this.Btn_Nhap_Click);
            // 
            // Bn_Tiep
            // 
            this.Bn_Tiep.AutoSize = true;
            this.Bn_Tiep.Location = new System.Drawing.Point(68, 278);
            this.Bn_Tiep.Name = "Bn_Tiep";
            this.Bn_Tiep.Size = new System.Drawing.Size(81, 30);
            this.Bn_Tiep.TabIndex = 1;
            this.Bn_Tiep.Text = "Tiếp tục";
            this.Bn_Tiep.UseVisualStyleBackColor = true;
            this.Bn_Tiep.Click += new System.EventHandler(this.Bn_tiep_Click);
            // 
            // Btn_Thoat
            // 
            this.Btn_Thoat.AutoSize = true;
            this.Btn_Thoat.Location = new System.Drawing.Point(233, 278);
            this.Btn_Thoat.Name = "Btn_Thoat";
            this.Btn_Thoat.Size = new System.Drawing.Size(81, 30);
            this.Btn_Thoat.TabIndex = 2;
            this.Btn_Thoat.Text = "Thoát";
            this.Btn_Thoat.UseVisualStyleBackColor = true;
            this.Btn_Thoat.Click += new System.EventHandler(this.Btn_thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(78, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập Dãy Số Và Tính Tổng";
            // 
            // Lbl_Nhap
            // 
            this.Lbl_Nhap.AutoSize = true;
            this.Lbl_Nhap.Location = new System.Drawing.Point(39, 85);
            this.Lbl_Nhap.Name = "Lbl_Nhap";
            this.Lbl_Nhap.Size = new System.Drawing.Size(68, 20);
            this.Lbl_Nhap.TabIndex = 4;
            this.Lbl_Nhap.Text = "Nhập số";
            // 
            // Lbl_Dayvuanhap
            // 
            this.Lbl_Dayvuanhap.AutoSize = true;
            this.Lbl_Dayvuanhap.Location = new System.Drawing.Point(39, 131);
            this.Lbl_Dayvuanhap.Name = "Lbl_Dayvuanhap";
            this.Lbl_Dayvuanhap.Size = new System.Drawing.Size(110, 20);
            this.Lbl_Dayvuanhap.TabIndex = 5;
            this.Lbl_Dayvuanhap.Text = "Dãy vừa nhập:";
            // 
            // Lbl_Tong
            // 
            this.Lbl_Tong.AutoSize = true;
            this.Lbl_Tong.Location = new System.Drawing.Point(39, 185);
            this.Lbl_Tong.Name = "Lbl_Tong";
            this.Lbl_Tong.Size = new System.Drawing.Size(206, 20);
            this.Lbl_Tong.TabIndex = 6;
            this.Lbl_Tong.Text = "Tổng các phần tử trong dãy:";
            // 
            // Lbl_TC
            // 
            this.Lbl_TC.AutoSize = true;
            this.Lbl_TC.Location = new System.Drawing.Point(39, 236);
            this.Lbl_TC.Name = "Lbl_TC";
            this.Lbl_TC.Size = new System.Drawing.Size(88, 20);
            this.Lbl_TC.TabIndex = 7;
            this.Lbl_TC.Text = "Tổng chẵn:";
            // 
            // Lbl_TL
            // 
            this.Lbl_TL.AutoSize = true;
            this.Lbl_TL.Location = new System.Drawing.Point(229, 236);
            this.Lbl_TL.Name = "Lbl_TL";
            this.Lbl_TL.Size = new System.Drawing.Size(65, 20);
            this.Lbl_TL.TabIndex = 8;
            this.Lbl_TL.Text = "Tông lẻ:";
            // 
            // Txt_Nhap
            // 
            this.Txt_Nhap.Location = new System.Drawing.Point(155, 79);
            this.Txt_Nhap.Name = "Txt_Nhap";
            this.Txt_Nhap.Size = new System.Drawing.Size(69, 26);
            this.Txt_Nhap.TabIndex = 9;
            // 
            // Txt_Dayvuanhap
            // 
            this.Txt_Dayvuanhap.Location = new System.Drawing.Point(155, 128);
            this.Txt_Dayvuanhap.Name = "Txt_Dayvuanhap";
            this.Txt_Dayvuanhap.Size = new System.Drawing.Size(69, 26);
            this.Txt_Dayvuanhap.TabIndex = 10;
            // 
            // Txt_Tong
            // 
            this.Txt_Tong.Location = new System.Drawing.Point(263, 179);
            this.Txt_Tong.Name = "Txt_Tong";
            this.Txt_Tong.Size = new System.Drawing.Size(69, 26);
            this.Txt_Tong.TabIndex = 10;
            // 
            // Txt_TC
            // 
            this.Txt_TC.Location = new System.Drawing.Point(131, 230);
            this.Txt_TC.Name = "Txt_TC";
            this.Txt_TC.Size = new System.Drawing.Size(69, 26);
            this.Txt_TC.TabIndex = 11;
            // 
            // Txt_TL
            // 
            this.Txt_TL.Location = new System.Drawing.Point(296, 230);
            this.Txt_TL.Name = "Txt_TL";
            this.Txt_TL.Size = new System.Drawing.Size(69, 26);
            this.Txt_TL.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 345);
            this.Controls.Add(this.Txt_TL);
            this.Controls.Add(this.Txt_TC);
            this.Controls.Add(this.Txt_Tong);
            this.Controls.Add(this.Txt_Dayvuanhap);
            this.Controls.Add(this.Txt_Nhap);
            this.Controls.Add(this.Lbl_TL);
            this.Controls.Add(this.Lbl_TC);
            this.Controls.Add(this.Lbl_Tong);
            this.Controls.Add(this.Lbl_Dayvuanhap);
            this.Controls.Add(this.Lbl_Nhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Thoat);
            this.Controls.Add(this.Bn_Tiep);
            this.Controls.Add(this.Btn_Nhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Nhap;
        private System.Windows.Forms.Button Bn_Tiep;
        private System.Windows.Forms.Button Btn_Thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Nhap;
        private System.Windows.Forms.Label Lbl_Dayvuanhap;
        private System.Windows.Forms.Label Lbl_Tong;
        private System.Windows.Forms.Label Lbl_TC;
        private System.Windows.Forms.Label Lbl_TL;
        private System.Windows.Forms.TextBox Txt_Nhap;
        private System.Windows.Forms.TextBox Txt_Dayvuanhap;
        private System.Windows.Forms.TextBox Txt_Tong;
        private System.Windows.Forms.TextBox Txt_TC;
        private System.Windows.Forms.TextBox Txt_TL;
    }
}

