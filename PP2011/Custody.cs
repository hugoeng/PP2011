/*
 * Created by SharpDevelop.
 * User: hugo
 * Date: 2011-03-29
 * Time: 12:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PP2011
{
	/// <summary>
	/// Description of Custody.
	/// </summary>
	public class Custody
	{
		private DateTime m_kStart, m_kEnd;
		private TimeSpan m_kTimeInCustody;
		
		public Custody(DateTime pStart, DateTime pEnd)
		{
			m_kStart = pStart;
			m_kEnd = pEnd;
			m_kTimeInCustody = m_kEnd - m_kStart;
		}
		
		public TimeSpan TimeInCustody
		{
			get {return m_kTimeInCustody;}
		}
		
		public DateTime StartDate
		{
			get {return m_kStart;}
		}
		
		public DateTime EndDate
		{
			get {return m_kEnd;}
		}
	}
}
