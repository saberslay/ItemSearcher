
namespace ItemSearcher
{
    partial class ItemSearcher
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
            this.Search_BTN = new System.Windows.Forms.Button();
            this.SearchBar_TB = new System.Windows.Forms.TextBox();
            this.LBBOX = new System.Windows.Forms.ListView();
            this.ListingID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.ItemCount_LB = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.uSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search_BTN
            // 
            this.Search_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_BTN.Location = new System.Drawing.Point(390, 25);
            this.Search_BTN.Name = "Search_BTN";
            this.Search_BTN.Size = new System.Drawing.Size(88, 23);
            this.Search_BTN.TabIndex = 0;
            this.Search_BTN.Text = "Search";
            this.Search_BTN.UseVisualStyleBackColor = true;
            this.Search_BTN.Click += new System.EventHandler(this.Search_BTN_Click);
            // 
            // SearchBar_TB
            // 
            this.SearchBar_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBar_TB.Location = new System.Drawing.Point(96, 27);
            this.SearchBar_TB.Name = "SearchBar_TB";
            this.SearchBar_TB.Size = new System.Drawing.Size(288, 20);
            this.SearchBar_TB.TabIndex = 1;
            this.SearchBar_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBar_TB_KeyPress);
            // 
            // LBBOX
            // 
            this.LBBOX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBBOX.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListingID,
            this.columnHeader1,
            this.columnHeader2});
            this.LBBOX.HideSelection = false;
            this.LBBOX.Location = new System.Drawing.Point(0, 54);
            this.LBBOX.Name = "LBBOX";
            this.LBBOX.Size = new System.Drawing.Size(478, 388);
            this.LBBOX.TabIndex = 2;
            this.LBBOX.UseCompatibleStateImageBehavior = false;
            this.LBBOX.View = System.Windows.Forms.View.Details;
            // 
            // ListingID
            // 
            this.ListingID.Text = "Listing id";
            this.ListingID.Width = 83;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Price";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item bid";
            this.columnHeader2.Width = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item Count:";
            // 
            // ItemCount_LB
            // 
            this.ItemCount_LB.AutoSize = true;
            this.ItemCount_LB.Location = new System.Drawing.Point(65, 30);
            this.ItemCount_LB.Name = "ItemCount_LB";
            this.ItemCount_LB.Size = new System.Drawing.Size(0, 13);
            this.ItemCount_LB.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regionsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // regionsToolStripMenuItem
            // 
            this.regionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uKToolStripMenuItem,
            this.toolStripSeparator1,
            this.uSToolStripMenuItem});
            this.regionsToolStripMenuItem.Name = "regionsToolStripMenuItem";
            this.regionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.regionsToolStripMenuItem.Text = "Regions";
            // 
            // uKToolStripMenuItem
            // 
            this.uKToolStripMenuItem.Checked = true;
            this.uKToolStripMenuItem.CheckOnClick = true;
            this.uKToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uKToolStripMenuItem.Name = "uKToolStripMenuItem";
            this.uKToolStripMenuItem.ShowShortcutKeys = false;
            this.uKToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.uKToolStripMenuItem.Text = "UK";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(79, 6);
            // 
            // uSToolStripMenuItem
            // 
            this.uSToolStripMenuItem.CheckOnClick = true;
            this.uSToolStripMenuItem.Name = "uSToolStripMenuItem";
            this.uSToolStripMenuItem.ShowShortcutKeys = false;
            this.uSToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.uSToolStripMenuItem.Text = "US";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 444);
            this.Controls.Add(this.ItemCount_LB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBBOX);
            this.Controls.Add(this.Search_BTN);
            this.Controls.Add(this.SearchBar_TB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ItemSearcher";
            this.Text = "Item Searcher";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchBar_TB;
        private System.Windows.Forms.Button Search_BTN;
        private System.Windows.Forms.ListView LBBOX;
        private System.Windows.Forms.ColumnHeader ListingID;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ItemCount_LB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uKToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem uSToolStripMenuItem;
    }
}

