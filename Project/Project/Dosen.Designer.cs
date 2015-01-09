namespace Project
{
    partial class Dosen
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuButtonItem1 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuButtonItem2 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuButtonItem3 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuButtonItem4 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "";
            this.textBox1.Location = new System.Drawing.Point(72, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "NID Dosen";
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuButtonItem1,
            this.radMenuButtonItem2,
            this.radMenuButtonItem3,
            this.radMenuButtonItem4});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.radMenu1.Size = new System.Drawing.Size(677, 29);
            this.radMenu1.TabIndex = 9;
            this.radMenu1.Text = "radMenu1";
            this.radMenu1.ThemeName = "TelerikMetroBlue";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "Dosen";
            this.radMenuItem1.AccessibleName = "Dosen";
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem2,
            this.radMenuItem3,
            this.radMenuItem4});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Dosen";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "Add Dosen";
            this.radMenuItem2.AccessibleName = "Add Dosen";
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Add Dosen";
            this.radMenuItem2.Click += new System.EventHandler(this.radMenuItem2_Click);
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.AccessibleDescription = "Edit Dosen";
            this.radMenuItem3.AccessibleName = "Edit Dosen";
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Edit Dosen";
            this.radMenuItem3.Click += new System.EventHandler(this.radMenuItem3_Click);
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.AccessibleDescription = "Delete Dosen";
            this.radMenuItem4.AccessibleName = "Delete Dosen";
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Delete Dosen";
            this.radMenuItem4.Click += new System.EventHandler(this.radMenuItem4_Click);
            // 
            // radMenuButtonItem1
            // 
            this.radMenuButtonItem1.AccessibleDescription = "List";
            this.radMenuButtonItem1.AccessibleName = "List";
            this.radMenuButtonItem1.AutoSize = false;
            this.radMenuButtonItem1.Bounds = new System.Drawing.Rectangle(0, 0, 80, 23);
            // 
            // 
            // 
            this.radMenuButtonItem1.ButtonElement.AccessibleDescription = "List";
            this.radMenuButtonItem1.ButtonElement.AccessibleName = "List";
            this.radMenuButtonItem1.Name = "radMenuButtonItem1";
            this.radMenuButtonItem1.Text = "List";
            this.radMenuButtonItem1.Click += new System.EventHandler(this.radMenuButtonItem1_Click);
            // 
            // radMenuButtonItem2
            // 
            this.radMenuButtonItem2.AccessibleDescription = "Print";
            this.radMenuButtonItem2.AccessibleName = "Print";
            this.radMenuButtonItem2.AutoSize = false;
            this.radMenuButtonItem2.Bounds = new System.Drawing.Rectangle(0, 0, 80, 23);
            // 
            // 
            // 
            this.radMenuButtonItem2.ButtonElement.AccessibleDescription = "Print";
            this.radMenuButtonItem2.ButtonElement.AccessibleName = "Print";
            this.radMenuButtonItem2.Name = "radMenuButtonItem2";
            this.radMenuButtonItem2.Text = "Print";
            this.radMenuButtonItem2.Click += new System.EventHandler(this.radMenuButtonItem2_Click);
            // 
            // radMenuButtonItem3
            // 
            this.radMenuButtonItem3.AccessibleDescription = "Exit";
            this.radMenuButtonItem3.AccessibleName = "Exit";
            this.radMenuButtonItem3.AutoSize = false;
            this.radMenuButtonItem3.Bounds = new System.Drawing.Rectangle(0, 0, 80, 23);
            // 
            // 
            // 
            this.radMenuButtonItem3.ButtonElement.AccessibleDescription = "Exit";
            this.radMenuButtonItem3.ButtonElement.AccessibleName = "Exit";
            this.radMenuButtonItem3.Name = "radMenuButtonItem3";
            this.radMenuButtonItem3.Text = "Exit";
            this.radMenuButtonItem3.Click += new System.EventHandler(this.radMenuButtonItem3_Click);
            // 
            // radMenuButtonItem4
            // 
            this.radMenuButtonItem4.AccessibleDescription = "Back";
            this.radMenuButtonItem4.AccessibleName = "Back";
            this.radMenuButtonItem4.AutoSize = false;
            this.radMenuButtonItem4.Bounds = new System.Drawing.Rectangle(0, 0, 80, 23);
            // 
            // 
            // 
            this.radMenuButtonItem4.ButtonElement.AccessibleDescription = "Back";
            this.radMenuButtonItem4.ButtonElement.AccessibleName = "Back";
            this.radMenuButtonItem4.Name = "radMenuButtonItem4";
            this.radMenuButtonItem4.Text = "Back";
            this.radMenuButtonItem4.Click += new System.EventHandler(this.radMenuButtonItem4_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(12, 74);
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(653, 452);
            this.radGridView1.TabIndex = 10;
            this.radGridView1.Text = "radGridView1";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(198, 34);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 11;
            this.radButton1.Text = "Delete Dosen";
            this.radButton1.ThemeName = "TelerikMetroBlue";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // Dosen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 538);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Dosen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dosen";
            this.Load += new System.EventHandler(this.Dosen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem1;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem2;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem3;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem4;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton radButton1;

    }
}