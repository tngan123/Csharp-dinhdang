namespace Csharp_dinhdang
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbllaptrinh = new System.Windows.Forms.Label();
            this.grbFont = new System.Windows.Forms.GroupBox();
            this.chkGachchan = new System.Windows.Forms.CheckBox();
            this.chkNghien = new System.Windows.Forms.CheckBox();
            this.chkDam = new System.Windows.Forms.CheckBox();
            this.grbMau = new System.Windows.Forms.GroupBox();
            this.rdbBlack = new System.Windows.Forms.RadioButton();
            this.rdbBlue = new System.Windows.Forms.RadioButton();
            this.rdbGreen = new System.Windows.Forms.RadioButton();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.txtNhapten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbFont.SuspendLayout();
            this.grbMau.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(511, 369);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(286, 75);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbllaptrinh
            // 
            this.lbllaptrinh.AutoSize = true;
            this.lbllaptrinh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbllaptrinh.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllaptrinh.Location = new System.Drawing.Point(255, 397);
            this.lbllaptrinh.Name = "lbllaptrinh";
            this.lbllaptrinh.Size = new System.Drawing.Size(42, 23);
            this.lbllaptrinh.TabIndex = 11;
            this.lbllaptrinh.Text = "Tên";
            this.lbllaptrinh.Click += new System.EventHandler(this.lbllaptrinh_Click);
            // 
            // grbFont
            // 
            this.grbFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grbFont.Controls.Add(this.chkGachchan);
            this.grbFont.Controls.Add(this.chkNghien);
            this.grbFont.Controls.Add(this.chkDam);
            this.grbFont.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFont.Location = new System.Drawing.Point(489, 133);
            this.grbFont.Name = "grbFont";
            this.grbFont.Size = new System.Drawing.Size(322, 197);
            this.grbFont.TabIndex = 10;
            this.grbFont.TabStop = false;
            this.grbFont.Text = "Font";
            // 
            // chkGachchan
            // 
            this.chkGachchan.AutoSize = true;
            this.chkGachchan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGachchan.ForeColor = System.Drawing.Color.Blue;
            this.chkGachchan.Location = new System.Drawing.Point(22, 156);
            this.chkGachchan.Name = "chkGachchan";
            this.chkGachchan.Size = new System.Drawing.Size(119, 27);
            this.chkGachchan.TabIndex = 0;
            this.chkGachchan.Text = "Gạch chân";
            this.chkGachchan.UseVisualStyleBackColor = true;
            this.chkGachchan.CheckedChanged += new System.EventHandler(this.chkGachchan_CheckedChanged);
            // 
            // chkNghien
            // 
            this.chkNghien.AutoSize = true;
            this.chkNghien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNghien.ForeColor = System.Drawing.Color.Blue;
            this.chkNghien.Location = new System.Drawing.Point(22, 94);
            this.chkNghien.Name = "chkNghien";
            this.chkNghien.Size = new System.Drawing.Size(146, 27);
            this.chkNghien.TabIndex = 0;
            this.chkNghien.Text = "Nghiêng Italic";
            this.chkNghien.UseVisualStyleBackColor = true;
            this.chkNghien.CheckedChanged += new System.EventHandler(this.chkNghien_CheckedChanged);
            // 
            // chkDam
            // 
            this.chkDam.AutoSize = true;
            this.chkDam.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDam.ForeColor = System.Drawing.Color.Blue;
            this.chkDam.Location = new System.Drawing.Point(22, 33);
            this.chkDam.Name = "chkDam";
            this.chkDam.Size = new System.Drawing.Size(110, 27);
            this.chkDam.TabIndex = 0;
            this.chkDam.Text = "Đậm Bold";
            this.chkDam.UseVisualStyleBackColor = true;
            this.chkDam.CheckedChanged += new System.EventHandler(this.chkDam_CheckedChanged);
            // 
            // grbMau
            // 
            this.grbMau.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grbMau.Controls.Add(this.rdbBlack);
            this.grbMau.Controls.Add(this.rdbBlue);
            this.grbMau.Controls.Add(this.rdbGreen);
            this.grbMau.Controls.Add(this.rdbRed);
            this.grbMau.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMau.Location = new System.Drawing.Point(175, 133);
            this.grbMau.Name = "grbMau";
            this.grbMau.Size = new System.Drawing.Size(200, 197);
            this.grbMau.TabIndex = 9;
            this.grbMau.TabStop = false;
            this.grbMau.Text = "Màu";
            // 
            // rdbBlack
            // 
            this.rdbBlack.AutoSize = true;
            this.rdbBlack.Location = new System.Drawing.Point(6, 156);
            this.rdbBlack.Name = "rdbBlack";
            this.rdbBlack.Size = new System.Drawing.Size(71, 27);
            this.rdbBlack.TabIndex = 0;
            this.rdbBlack.TabStop = true;
            this.rdbBlack.Text = "Black";
            this.rdbBlack.UseVisualStyleBackColor = true;
            this.rdbBlack.CheckedChanged += new System.EventHandler(this.rdbBlack_CheckedChanged);
            // 
            // rdbBlue
            // 
            this.rdbBlue.AutoSize = true;
            this.rdbBlue.ForeColor = System.Drawing.Color.Blue;
            this.rdbBlue.Location = new System.Drawing.Point(6, 115);
            this.rdbBlue.Name = "rdbBlue";
            this.rdbBlue.Size = new System.Drawing.Size(64, 27);
            this.rdbBlue.TabIndex = 0;
            this.rdbBlue.TabStop = true;
            this.rdbBlue.Text = "Blue";
            this.rdbBlue.UseVisualStyleBackColor = true;
            this.rdbBlue.CheckedChanged += new System.EventHandler(this.rdbBlue_CheckedChanged);
            // 
            // rdbGreen
            // 
            this.rdbGreen.AutoSize = true;
            this.rdbGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdbGreen.Location = new System.Drawing.Point(6, 74);
            this.rdbGreen.Name = "rdbGreen";
            this.rdbGreen.Size = new System.Drawing.Size(79, 27);
            this.rdbGreen.TabIndex = 0;
            this.rdbGreen.TabStop = true;
            this.rdbGreen.Text = "Green";
            this.rdbGreen.UseVisualStyleBackColor = true;
            this.rdbGreen.CheckedChanged += new System.EventHandler(this.rdbGreen_CheckedChanged);
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.ForeColor = System.Drawing.Color.Red;
            this.rdbRed.Location = new System.Drawing.Point(6, 33);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(61, 27);
            this.rdbRed.TabIndex = 0;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "Red";
            this.rdbRed.UseVisualStyleBackColor = true;
            this.rdbRed.CheckedChanged += new System.EventHandler(this.rdbRed_CheckedChanged);
            // 
            // txtNhapten
            // 
            this.txtNhapten.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapten.Location = new System.Drawing.Point(348, 52);
            this.txtNhapten.Name = "txtNhapten";
            this.txtNhapten.Size = new System.Drawing.Size(163, 36);
            this.txtNhapten.TabIndex = 8;
            this.txtNhapten.TextChanged += new System.EventHandler(this.txtNhapten_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(107, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lập trình bởi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập tên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 493);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lbllaptrinh);
            this.Controls.Add(this.grbFont);
            this.Controls.Add(this.grbMau);
            this.Controls.Add(this.txtNhapten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbFont.ResumeLayout(false);
            this.grbFont.PerformLayout();
            this.grbMau.ResumeLayout(false);
            this.grbMau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbllaptrinh;
        private System.Windows.Forms.GroupBox grbFont;
        private System.Windows.Forms.CheckBox chkGachchan;
        private System.Windows.Forms.CheckBox chkNghien;
        private System.Windows.Forms.CheckBox chkDam;
        private System.Windows.Forms.GroupBox grbMau;
        private System.Windows.Forms.RadioButton rdbBlack;
        private System.Windows.Forms.RadioButton rdbBlue;
        private System.Windows.Forms.RadioButton rdbGreen;
        private System.Windows.Forms.RadioButton rdbRed;
        private System.Windows.Forms.TextBox txtNhapten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

