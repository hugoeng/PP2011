/*
 * Created by SharpDevelop.
 * User: hugo
 * Date: 2011-03-23
 * Time: 19:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
using System.Windows.Forms;
using System.Drawing;
 
namespace PP2011
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelSummarySentence = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newPlanningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.labelCalculation = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// labelSummarySentence
			// 
			this.labelSummarySentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSummarySentence.Location = new System.Drawing.Point(46, 49);
			this.labelSummarySentence.Name = "labelSummarySentence";
			this.labelSummarySentence.Size = new System.Drawing.Size(651, 23);
			this.labelSummarySentence.TabIndex = 0;
			this.labelSummarySentence.Text = "ex 2 ÅRS Fängelse....";
			this.labelSummarySentence.Click += new System.EventHandler(this.Label1Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newPlanningToolStripMenuItem,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.fileToolStripMenuItem.Text = "Arkiv";
			// 
			// newPlanningToolStripMenuItem
			// 
			this.newPlanningToolStripMenuItem.Name = "newPlanningToolStripMenuItem";
			this.newPlanningToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.newPlanningToolStripMenuItem.Text = "Ny Planering";
			this.newPlanningToolStripMenuItem.Click += new System.EventHandler(this.NewPlanningToolStripMenuItemClick);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Avsluta";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem1});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.helpToolStripMenuItem.Text = "Hjälp";
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
			this.aboutToolStripMenuItem1.Text = "Om PP2011";
			this.aboutToolStripMenuItem1.ToolTipText = "Om PermissionsPlanerare 2011";
			this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// labelCalculation
			// 
			this.labelCalculation.Location = new System.Drawing.Point(46, 488);
			this.labelCalculation.Name = "labelCalculation";
			this.labelCalculation.Size = new System.Drawing.Size(100, 23);
			this.labelCalculation.TabIndex = 2;
			this.labelCalculation.Text = "Uträkning";
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.DarkGoldenrod;
			this.pictureBox1.Location = new System.Drawing.Point(46, 75);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(651, 387);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Cornsilk;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.labelCalculation);
			this.Controls.Add(this.labelSummarySentence);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "PP2011";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label labelSummarySentence;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newPlanningToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.Label labelCalculation;
		private System.Windows.Forms.ImageList imageList1;
		
	
		void Label1Click(object sender, System.EventArgs e)
		{

		}
	
		void NewPlanningToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			EnterSentenceForm form = new EnterSentenceForm();
			form.ShowDialog();
		}
		
		void ExitToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
		
		void AboutToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			MessageBox.Show("PP2011 är ett program för att lättare kunna planera permissionsperider enligt FARK.","PP2011");
		}
		
		
	}
}
