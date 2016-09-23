/*
 * Erstellt mit SharpDevelop.
 * Benutzer: xv8887a
 * Datum: 07.09.2016
 * Zeit: 13:51
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjeckEditor
{
		
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//

		}
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		void BtnOpenProjectClick(object sender, EventArgs e)
		{
			if (lstProjects.SelectedItem != null) {
				lstProjects.Enabled = !lstProjects.Enabled;
				btnOpenProject.Text = lstProjects.Enabled ? "Open" : "Close";
				rtxtPrjHdr.ReadOnly = lstProjects.Enabled;
			}
		}
		void RtxtPrjHdrTextChanged(object sender, EventArgs e)
		{
			int currpos = rtxtPrjHdr.SelectionStart;
						
			int lineindex =	rtxtPrjHdr.GetLineFromCharIndex (currpos);

			string line = rtxtPrjHdr.Lines.Length>0 ? rtxtPrjHdr.Lines[lineindex]:"" ;
			
			if (line.Contains("#")) {
						

					rtxtPrjHdr.Select(rtxtPrjHdr.GetFirstCharIndexFromLine(lineindex), line.Length);
					rtxtPrjHdr.SelectionColor = Color.DarkGreen;
					rtxtPrjHdr.SelectionFont= new Font(rtxtPrjHdr.SelectionFont.FontFamily,rtxtPrjHdr.SelectionFont.Size,FontStyle.Italic);
					rtxtPrjHdr.SelectionStart=currpos;
					rtxtPrjHdr.SelectionLength=0;
				}
				
				rtxtPrjHdr.SelectionColor = Color.Black;
				rtxtPrjHdr.SelectionFont= new Font(rtxtPrjHdr.SelectionFont.FontFamily,rtxtPrjHdr.SelectionFont.Size,FontStyle.Regular);
			
			
		}
		
	}
	public interface IMainForm
	{
		
		
	}
}
