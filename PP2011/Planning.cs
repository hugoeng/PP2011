/*
 * Created by SharpDevelop.
 * User: hugo
 * Date: 2011-03-24
 * Time: 12:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace PP2011
{
	/// <summary>
	/// Description of Planning.
	/// </summary>
	public class Planning
	{
		private Custody m_kCustody;
		private bool m_bCustody;
		private Sentence m_kSentence;
		
		private List<Period> m_kPeriods;
		
		public Planning()
		{
			m_kSentence = null;
			m_bCustody = false;	
		}
		
		public void AddCustody(Custody p)
		{
			m_bCustody = true;
			m_kCustody = p;
		}
	}
}
