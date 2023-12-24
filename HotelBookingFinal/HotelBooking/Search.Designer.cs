
namespace HotelBooking
{
    partial class Search
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonID = new System.Windows.Forms.RadioButton();
            this.radioButtonPhone = new System.Windows.Forms.RadioButton();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewSearchResult = new System.Windows.Forms.DataGridView();
            this.pictureBoxX = new System.Windows.Forms.PictureBox();
            this.pictureBoxLinkedin = new System.Windows.Forms.PictureBox();
            this.pictureBoxfb = new System.Windows.Forms.PictureBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabelAboutUs = new System.Windows.Forms.LinkLabel();
            this.linkLabelTandC = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabelGallery = new System.Windows.Forms.LinkLabel();
            this.linkLabelHome = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLinkedin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Customers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonID);
            this.groupBox2.Controls.Add(this.radioButtonPhone);
            this.groupBox2.Controls.Add(this.radioButtonName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(42, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 55);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonID
            // 
            this.radioButtonID.AutoSize = true;
            this.radioButtonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonID.Location = new System.Drawing.Point(40, 23);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Size = new System.Drawing.Size(107, 20);
            this.radioButtonID.TabIndex = 5;
            this.radioButtonID.TabStop = true;
            this.radioButtonID.Text = "By Identity No";
            this.radioButtonID.UseVisualStyleBackColor = true;
            // 
            // radioButtonPhone
            // 
            this.radioButtonPhone.AutoSize = true;
            this.radioButtonPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPhone.Location = new System.Drawing.Point(387, 23);
            this.radioButtonPhone.Name = "radioButtonPhone";
            this.radioButtonPhone.Size = new System.Drawing.Size(107, 20);
            this.radioButtonPhone.TabIndex = 5;
            this.radioButtonPhone.TabStop = true;
            this.radioButtonPhone.Text = "By Phone No ";
            this.radioButtonPhone.UseVisualStyleBackColor = true;
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonName.Location = new System.Drawing.Point(229, 21);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(81, 20);
            this.radioButtonName.TabIndex = 5;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "By Name";
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonSearch.FlatAppearance.BorderSize = 2;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(618, 155);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(87, 38);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Customers by ID , Name  or Phone Number :";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(42, 82);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(672, 22);
            this.textBoxSearch.TabIndex = 1;
            // 
            // dataGridViewSearchResult
            // 
            this.dataGridViewSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchResult.Location = new System.Drawing.Point(173, 313);
            this.dataGridViewSearchResult.Name = "dataGridViewSearchResult";
            this.dataGridViewSearchResult.Size = new System.Drawing.Size(430, 173);
            this.dataGridViewSearchResult.TabIndex = 4;
            // 
            // pictureBoxX
            // 
            this.pictureBoxX.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxX.Image = global::HotelBooking.Properties.Resources.x;
            this.pictureBoxX.Location = new System.Drawing.Point(486, 582);
            this.pictureBoxX.Name = "pictureBoxX";
            this.pictureBoxX.Size = new System.Drawing.Size(32, 31);
            this.pictureBoxX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxX.TabIndex = 26;
            this.pictureBoxX.TabStop = false;
            // 
            // pictureBoxLinkedin
            // 
            this.pictureBoxLinkedin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxLinkedin.Image = global::HotelBooking.Properties.Resources.linkedin;
            this.pictureBoxLinkedin.Location = new System.Drawing.Point(426, 582);
            this.pictureBoxLinkedin.Name = "pictureBoxLinkedin";
            this.pictureBoxLinkedin.Size = new System.Drawing.Size(32, 31);
            this.pictureBoxLinkedin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLinkedin.TabIndex = 25;
            this.pictureBoxLinkedin.TabStop = false;
            // 
            // pictureBoxfb
            // 
            this.pictureBoxfb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxfb.Image = global::HotelBooking.Properties.Resources.fb;
            this.pictureBoxfb.Location = new System.Drawing.Point(364, 582);
            this.pictureBoxfb.Name = "pictureBoxfb";
            this.pictureBoxfb.Size = new System.Drawing.Size(32, 31);
            this.pictureBoxfb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxfb.TabIndex = 24;
            this.pictureBoxfb.TabStop = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(664, 545);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(83, 18);
            this.linkLabel2.TabIndex = 23;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Contact Us";
            // 
            // linkLabelAboutUs
            // 
            this.linkLabelAboutUs.AutoSize = true;
            this.linkLabelAboutUs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabelAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAboutUs.LinkColor = System.Drawing.Color.White;
            this.linkLabelAboutUs.Location = new System.Drawing.Point(534, 545);
            this.linkLabelAboutUs.Name = "linkLabelAboutUs";
            this.linkLabelAboutUs.Size = new System.Drawing.Size(69, 18);
            this.linkLabelAboutUs.TabIndex = 22;
            this.linkLabelAboutUs.TabStop = true;
            this.linkLabelAboutUs.Text = "About Us";
            // 
            // linkLabelTandC
            // 
            this.linkLabelTandC.AutoSize = true;
            this.linkLabelTandC.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabelTandC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelTandC.LinkColor = System.Drawing.Color.White;
            this.linkLabelTandC.Location = new System.Drawing.Point(191, 545);
            this.linkLabelTandC.Name = "linkLabelTandC";
            this.linkLabelTandC.Size = new System.Drawing.Size(154, 18);
            this.linkLabelTandC.TabIndex = 21;
            this.linkLabelTandC.TabStop = true;
            this.linkLabelTandC.Text = "Terms and Conditions";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(64, 545);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 18);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Gallery";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(-20, 528);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(835, 100);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // linkLabelGallery
            // 
            this.linkLabelGallery.AutoSize = true;
            this.linkLabelGallery.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabelGallery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelGallery.LinkColor = System.Drawing.Color.White;
            this.linkLabelGallery.Location = new System.Drawing.Point(453, 13);
            this.linkLabelGallery.Name = "linkLabelGallery";
            this.linkLabelGallery.Size = new System.Drawing.Size(54, 18);
            this.linkLabelGallery.TabIndex = 9;
            this.linkLabelGallery.TabStop = true;
            this.linkLabelGallery.Text = "Gallery";
            this.linkLabelGallery.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGallery_LinkClicked);
            // 
            // linkLabelHome
            // 
            this.linkLabelHome.AutoSize = true;
            this.linkLabelHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelHome.LinkColor = System.Drawing.Color.White;
            this.linkLabelHome.Location = new System.Drawing.Point(298, 13);
            this.linkLabelHome.Name = "linkLabelHome";
            this.linkLabelHome.Size = new System.Drawing.Size(49, 18);
            this.linkLabelHome.TabIndex = 8;
            this.linkLabelHome.TabStop = true;
            this.linkLabelHome.Text = "Home";
            this.linkLabelHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHome_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 42);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.linkLabelGallery);
            this.Controls.Add(this.pictureBoxX);
            this.Controls.Add(this.linkLabelHome);
            this.Controls.Add(this.pictureBoxLinkedin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxfb);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabelAboutUs);
            this.Controls.Add(this.linkLabelTandC);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridViewSearchResult);
            this.Controls.Add(this.groupBox1);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLinkedin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewSearchResult;
        private System.Windows.Forms.RadioButton radioButtonID;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonPhone;
        private System.Windows.Forms.PictureBox pictureBoxX;
        private System.Windows.Forms.PictureBox pictureBoxLinkedin;
        private System.Windows.Forms.PictureBox pictureBoxfb;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabelAboutUs;
        private System.Windows.Forms.LinkLabel linkLabelTandC;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabelGallery;
        private System.Windows.Forms.LinkLabel linkLabelHome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

