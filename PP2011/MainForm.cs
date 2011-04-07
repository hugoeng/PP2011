/*
 * Created by SharpDevelop.
 * User: hugo
 * Date: 2011-03-23
 * Time: 19:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PP2011
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		PlanningPainter m_planningPainter;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//	

			// Set 
			m_planningPainter = new PlanningPainter(pictureBox1);			
			pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.m_planningPainter.Paint);

		}
		
		
	}
}
