/*
 * Created by SharpDevelop.
 * User: hugo
 * Date: 2011-03-24
 * Time: 12:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PP2011
{
	/// <summary>
	/// Description of Sentence.
	/// </summary>
	public class Sentence
	{
		private string m_strDescription;
		private int m_iYears,m_iMonths,m_iDays;
		
		public void Sentance(){}
		
		public void SetSentance(int pYears,int pMonths,int pDays)
		{
			if(pYears == 0 && pMonths == 0 && pDays == 0)
			{
				throw new InvalidOperationException("Sentences must be at least 1 DAY!");
			}
			
			m_iYears = pYears;
			m_iMonths = pMonths;
			m_iDays = pDays;
			
			SetString();
		}
		
		public override string ToString()
		{
			return m_strDescription;
		}
		
		public void SetString()
		{
			m_strDescription = "Fängelse ";
			
			bool start = false;
			
			if(m_iYears > 0)
			{	
				start = true;
				m_strDescription += m_iYears + " ÅR";
			}
			if(m_iMonths > 0)
			{
				if(start)
				{
					m_strDescription += ", ";
				}
				m_strDescription += m_iMonths + " MÅN";
			}
			if(m_iDays > 0)
			{
				if(start)
				{
					m_strDescription += ", ";
				}
				m_strDescription += m_iDays + " DAGAR";
			}
		}	
	}
}
