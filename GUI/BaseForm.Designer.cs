namespace GUI
{
	partial class BaseForm
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
			this.navigation_MenuStrip = new System.Windows.Forms.MenuStrip();
			this.file_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.create_new_file_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.open_file_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.save_file_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.save_as_another_file_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.close_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.content_area_RichTextBox = new System.Windows.Forms.RichTextBox();
			this.navigation_MenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// navigation_MenuStrip
			// 
			this.navigation_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_ToolStripMenuItem});
			this.navigation_MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.navigation_MenuStrip.Name = "navigation_MenuStrip";
			this.navigation_MenuStrip.Size = new System.Drawing.Size(800, 25);
			this.navigation_MenuStrip.TabIndex = 0;
			this.navigation_MenuStrip.Text = "menuStrip1";
			// 
			// file_ToolStripMenuItem
			// 
			this.file_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.create_new_file_ToolStripMenuItem,
            this.open_file_ToolStripMenuItem,
            this.save_file_ToolStripMenuItem,
            this.save_as_another_file_ToolStripMenuItem,
            this.close_ToolStripMenuItem});
			this.file_ToolStripMenuItem.Name = "file_ToolStripMenuItem";
			this.file_ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.file_ToolStripMenuItem.Text = "文件";
			// 
			// create_new_file_ToolStripMenuItem
			// 
			this.create_new_file_ToolStripMenuItem.Name = "create_new_file_ToolStripMenuItem";
			this.create_new_file_ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.create_new_file_ToolStripMenuItem.Text = "新建";
			// 
			// open_file_ToolStripMenuItem
			// 
			this.open_file_ToolStripMenuItem.Name = "open_file_ToolStripMenuItem";
			this.open_file_ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.open_file_ToolStripMenuItem.Text = "打开";
			// 
			// save_file_ToolStripMenuItem
			// 
			this.save_file_ToolStripMenuItem.Name = "save_file_ToolStripMenuItem";
			this.save_file_ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.save_file_ToolStripMenuItem.Text = "保存";
			// 
			// save_as_another_file_ToolStripMenuItem
			// 
			this.save_as_another_file_ToolStripMenuItem.Name = "save_as_another_file_ToolStripMenuItem";
			this.save_as_another_file_ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.save_as_another_file_ToolStripMenuItem.Text = "另存为";
			// 
			// close_ToolStripMenuItem
			// 
			this.close_ToolStripMenuItem.Name = "close_ToolStripMenuItem";
			this.close_ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.close_ToolStripMenuItem.Text = "关闭";
			// 
			// content_area_RichTextBox
			// 
			this.content_area_RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.content_area_RichTextBox.Location = new System.Drawing.Point(0, 25);
			this.content_area_RichTextBox.Name = "content_area_RichTextBox";
			this.content_area_RichTextBox.Size = new System.Drawing.Size(800, 425);
			this.content_area_RichTextBox.TabIndex = 1;
			this.content_area_RichTextBox.Text = "";
			// 
			// BaseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.content_area_RichTextBox);
			this.Controls.Add(this.navigation_MenuStrip);
			this.MainMenuStrip = this.navigation_MenuStrip;
			this.Name = "BaseForm";
			this.Text = "BaseForm";
			this.navigation_MenuStrip.ResumeLayout(false);
			this.navigation_MenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.MenuStrip navigation_MenuStrip;
		public System.Windows.Forms.ToolStripMenuItem file_ToolStripMenuItem;
		public System.Windows.Forms.RichTextBox content_area_RichTextBox;
		public System.Windows.Forms.ToolStripMenuItem create_new_file_ToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem open_file_ToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem save_file_ToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem save_as_another_file_ToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem close_ToolStripMenuItem;
	}
}