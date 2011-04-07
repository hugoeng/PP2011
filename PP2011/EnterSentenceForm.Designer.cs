/*
 * Created by SharpDevelop.
 * User: hugo
 * Date: 2011-03-24
 * Time: 12:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PP2011
{
	partial class EnterSentenceForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			this.sentenceLabel = new System.Windows.Forms.Label();
			this.arTextBox = new System.Windows.Forms.TextBox();
			this.manTextBox = new System.Windows.Forms.TextBox();
			this.dagTextBox = new System.Windows.Forms.TextBox();
			this.nextButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.yearLabel = new System.Windows.Forms.Label();
			this.monthLabel = new System.Windows.Forms.Label();
			this.dayLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// sentenceLabel
			// 
			this.sentenceLabel.Location = new System.Drawing.Point(39, 19);
			this.sentenceLabel.Name = "sentenceLabel";
			this.sentenceLabel.Size = new System.Drawing.Size(100, 23);
			this.sentenceLabel.TabIndex = 1;
			this.sentenceLabel.Text = "Strafftid";
			this.sentenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// arTextBox
			// 
			this.arTextBox.Location = new System.Drawing.Point(18, 78);
			this.arTextBox.Name = "arTextBox";
			this.arTextBox.Size = new System.Drawing.Size(35, 20);
			this.arTextBox.TabIndex = 2;
			// 
			// manTextBox
			// 
			this.manTextBox.Location = new System.Drawing.Point(68, 78);
			this.manTextBox.Name = "manTextBox";
			this.manTextBox.Size = new System.Drawing.Size(35, 20);
			this.manTextBox.TabIndex = 5;
			// 
			// dagTextBox
			// 
			this.dagTextBox.Location = new System.Drawing.Point(122, 78);
			this.dagTextBox.Name = "dagTextBox";
			this.dagTextBox.Size = new System.Drawing.Size(35, 20);
			this.dagTextBox.TabIndex = 6;
			// 
			// nextButton
			// 
			this.nextButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.nextButton.Location = new System.Drawing.Point(16, 123);
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new System.Drawing.Size(62, 22);
			this.nextButton.TabIndex = 7;
			this.nextButton.Text = "Next";
			this.nextButton.UseVisualStyleBackColor = true;
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(99, 124);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(60, 21);
			this.cancelButton.TabIndex = 8;
			this.cancelButton.Text = "Avbryt";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// yearLabel
			// 
			this.yearLabel.Location = new System.Drawing.Point(18, 52);
			this.yearLabel.Name = "yearLabel";
			this.yearLabel.Size = new System.Drawing.Size(35, 23);
			this.yearLabel.TabIndex = 9;
			this.yearLabel.Text = "ÅR";
			this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// monthLabel
			// 
			this.monthLabel.Location = new System.Drawing.Point(69, 52);
			this.monthLabel.Name = "monthLabel";
			this.monthLabel.Size = new System.Drawing.Size(35, 23);
			this.monthLabel.TabIndex = 10;
			this.monthLabel.Text = "MÅN";
			this.monthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dayLabel
			// 
			this.dayLabel.Location = new System.Drawing.Point(122, 52);
			this.dayLabel.Name = "dayLabel";
			this.dayLabel.Size = new System.Drawing.Size(34, 23);
			this.dayLabel.TabIndex = 11;
			this.dayLabel.Text = "DAG";
			this.dayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// EnterSentenceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.dayLabel);
			this.Controls.Add(this.monthLabel);
			this.Controls.Add(this.yearLabel);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.nextButton);
			this.Controls.Add(this.dagTextBox);
			this.Controls.Add(this.manTextBox);
			this.Controls.Add(this.arTextBox);
			this.Controls.Add(this.sentenceLabel);
			this.Name = "EnterSentenceForm";
			this.Size = new System.Drawing.Size(181, 164);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label sentenceLabel;
		private System.Windows.Forms.TextBox arTextBox;
		private System.Windows.Forms.TextBox manTextBox;
		private System.Windows.Forms.TextBox dagTextBox;
		private System.Windows.Forms.Label yearLabel;
		private System.Windows.Forms.Label monthLabel;
		private System.Windows.Forms.Label dayLabel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button nextButton;
	}
}
