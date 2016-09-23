/*
 * Erstellt mit SharpDevelop.
 * Benutzer: xv8887a
 * Datum: 07.09.2016
 * Zeit: 13:51
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace ProjeckEditor
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox lstProjects;
		private System.Windows.Forms.Button btnOpenProject;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.RichTextBox rtxtPrjHdr;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lstProjects = new System.Windows.Forms.ListBox();
			this.btnOpenProject = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.rtxtPrjHdr = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// lstProjects
			// 
			this.lstProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.lstProjects.FormattingEnabled = true;
			this.lstProjects.HorizontalScrollbar = true;
			this.lstProjects.Items.AddRange(new object[] {
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"78"});
			this.lstProjects.Location = new System.Drawing.Point(1, 12);
			this.lstProjects.MultiColumn = true;
			this.lstProjects.Name = "lstProjects";
			this.lstProjects.Size = new System.Drawing.Size(219, 693);
			this.lstProjects.Sorted = true;
			this.lstProjects.TabIndex = 0;
			this.lstProjects.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
			// 
			// btnOpenProject
			// 
			this.btnOpenProject.Location = new System.Drawing.Point(145, 725);
			this.btnOpenProject.Name = "btnOpenProject";
			this.btnOpenProject.Size = new System.Drawing.Size(75, 23);
			this.btnOpenProject.TabIndex = 1;
			this.btnOpenProject.Text = "Open";
			this.btnOpenProject.UseVisualStyleBackColor = true;
			this.btnOpenProject.Click += new System.EventHandler(this.BtnOpenProjectClick);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(12, 725);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 2;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			// 
			// rtxtPrjHdr
			// 
			this.rtxtPrjHdr.BackColor = System.Drawing.SystemColors.Window;
			this.rtxtPrjHdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtxtPrjHdr.ImeMode = System.Windows.Forms.ImeMode.Katakana;
			this.rtxtPrjHdr.Location = new System.Drawing.Point(227, 13);
			this.rtxtPrjHdr.Name = "rtxtPrjHdr";
			this.rtxtPrjHdr.ReadOnly = true;
			this.rtxtPrjHdr.Size = new System.Drawing.Size(677, 418);
			this.rtxtPrjHdr.TabIndex = 3;
			this.rtxtPrjHdr.Text = "";
			this.rtxtPrjHdr.WordWrap = false;
			this.rtxtPrjHdr.TextChanged += new System.EventHandler(this.RtxtPrjHdrTextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1091, 772);
			this.Controls.Add(this.rtxtPrjHdr);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnOpenProject);
			this.Controls.Add(this.lstProjects);
			this.Name = "MainForm";
			this.Text = "ProjeckEditor";
			this.ResumeLayout(false);

		}
	}
}