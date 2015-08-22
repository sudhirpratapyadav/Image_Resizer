namespace Image_Resizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn1 = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblp1 = new System.Windows.Forms.Label();
            this.lblp2 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tb_w = new System.Windows.Forms.TextBox();
            this.tb_h = new System.Windows.Forms.TextBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_s = new System.Windows.Forms.TextBox();
            this.chb2 = new System.Windows.Forms.CheckBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_spec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.cb4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.cb2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(384, 25);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(27, 20);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "...";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // tb1
            // 
            this.tb1.Enabled = false;
            this.tb1.Location = new System.Drawing.Point(12, 25);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(366, 20);
            this.tb1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Image";
            // 
            // lblp1
            // 
            this.lblp1.AutoSize = true;
            this.lblp1.Location = new System.Drawing.Point(13, 59);
            this.lblp1.Name = "lblp1";
            this.lblp1.Size = new System.Drawing.Size(77, 13);
            this.lblp1.TabIndex = 4;
            this.lblp1.Text = "Original Image ";
            // 
            // lblp2
            // 
            this.lblp2.AutoSize = true;
            this.lblp2.Location = new System.Drawing.Point(330, 59);
            this.lblp2.Name = "lblp2";
            this.lblp2.Size = new System.Drawing.Size(61, 13);
            this.lblp2.TabIndex = 5;
            this.lblp2.Text = "Final Image";
            // 
            // tb_w
            // 
            this.tb_w.Location = new System.Drawing.Point(333, 428);
            this.tb_w.Name = "tb_w";
            this.tb_w.Size = new System.Drawing.Size(87, 20);
            this.tb_w.TabIndex = 7;
            // 
            // tb_h
            // 
            this.tb_h.Location = new System.Drawing.Point(469, 427);
            this.tb_h.Name = "tb_h";
            this.tb_h.Size = new System.Drawing.Size(100, 20);
            this.tb_h.TabIndex = 8;
            // 
            // cb1
            // 
            this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "cm",
            "pixles",
            "inch"});
            this.cb1.Location = new System.Drawing.Point(582, 426);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(50, 21);
            this.cb1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Height";
            // 
            // tb_s
            // 
            this.tb_s.Enabled = false;
            this.tb_s.Location = new System.Drawing.Point(334, 381);
            this.tb_s.Name = "tb_s";
            this.tb_s.Size = new System.Drawing.Size(235, 20);
            this.tb_s.TabIndex = 16;
            // 
            // chb2
            // 
            this.chb2.AutoSize = true;
            this.chb2.Location = new System.Drawing.Point(334, 454);
            this.chb2.Name = "chb2";
            this.chb2.Size = new System.Drawing.Size(78, 17);
            this.chb2.TabIndex = 19;
            this.chb2.Text = "Grey Scale";
            this.chb2.UseVisualStyleBackColor = true;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(333, 75);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(300, 300);
            this.pb2.TabIndex = 6;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(16, 75);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(300, 300);
            this.pb1.TabIndex = 3;
            this.pb1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 32);
            this.button1.TabIndex = 22;
            this.button1.Text = "Apply Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 32);
            this.button2.TabIndex = 23;
            this.button2.Text = "Save Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_spec
            // 
            this.tb_spec.Enabled = false;
            this.tb_spec.Location = new System.Drawing.Point(15, 400);
            this.tb_spec.Multiline = true;
            this.tb_spec.Name = "tb_spec";
            this.tb_spec.Size = new System.Drawing.Size(301, 139);
            this.tb_spec.TabIndex = 24;
            this.tb_spec.Text = " Image Specifications";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Rotation";
            // 
            // cb3
            // 
            this.cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb3.FormattingEnabled = true;
            this.cb3.Items.AddRange(new object[] {
            "0 deg",
            "90 deg",
            "180 deg",
            "270 deg"});
            this.cb3.Location = new System.Drawing.Point(384, 477);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(50, 21);
            this.cb3.TabIndex = 27;
            // 
            // cb4
            // 
            this.cb4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb4.FormattingEnabled = true;
            this.cb4.Items.AddRange(new object[] {
            "None",
            "X",
            "Y"});
            this.cb4.Location = new System.Drawing.Point(582, 476);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(50, 21);
            this.cb4.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Flip";
            // 
            // cb2
            // 
            this.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2.Enabled = false;
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "png",
            "jpeg",
            "bmp",
            "gif"});
            this.cb2.Location = new System.Drawing.Point(582, 380);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(50, 21);
            this.cb2.TabIndex = 30;
            this.cb2.SelectedIndexChanged += new System.EventHandler(this.cb2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 547);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_spec);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chb2);
            this.Controls.Add(this.tb_s);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.tb_h);
            this.Controls.Add(this.tb_w);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.lblp2);
            this.Controls.Add(this.lblp1);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label lblp1;
        private System.Windows.Forms.Label lblp2;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.TextBox tb_w;
        private System.Windows.Forms.TextBox tb_h;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_s;
        private System.Windows.Forms.CheckBox chb2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_spec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.ComboBox cb4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.ComboBox cb2;
    }
}

