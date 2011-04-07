/*
 * Created by SharpDevelop.
 * User: hugo
 * Date: 2011-03-28
 * Time: 16:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PP2011
{
	/// <summary>
	/// Description of PlannerDrawer.
	/// </summary>
	public class PlanningPainter
	{
		private PictureBox m_picBox;
		private Planning m_kPlanning;
		
		public PlanningPainter(PictureBox pBox)
		{
			m_picBox = pBox;
		}
		
	public void Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
			// First paint the timeline based on 
		
		 	// Create a local version of the graphics object for the PictureBox.
   	 		Graphics g = e.Graphics;

    		// Draw a string on the PictureBox.
    		g.DrawString("This is a diagonal line drawn on the control",
        	new Font("Arial",10), System.Drawing.Brushes.Blue, new Point(30,30));
    		// Draw a line in the PictureBox.
    		g.DrawLine(System.Drawing.Pens.Red, m_picBox.Left, m_picBox.Top,
        	m_picBox.Right, m_picBox.Bottom);
		}
	}
}
