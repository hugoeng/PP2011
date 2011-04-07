/*
 * Created by SharpDevelop.
 * User: hugo
 * Date: 2011-03-28
 * Time: 14:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using NUnit.Framework;

namespace PP2011
{
	[TestFixture]
	public class Sentence_Tests
	{
		[Test]
		public void ToString_TwoYearsSixMonthsZeroDays_ReturnsValidString()
		{
			Sentence s = new Sentence();
			s.SetSentance(2,6,0);
			string str = s.ToString();
			Assert.AreEqual("Fängelse 2 ÅR, 6 MÅN", str, "error!");
		}
		
		[Test]
		public void ToString_ZeroYearsSixMonthsZeroDays_ReturnsValidString()
		{
			Sentence s = new Sentence();
			s.SetSentance(0,6,0);
			string str = s.ToString();
			Assert.AreEqual("Fängelse 6 MÅN", str, "error!");
		}
		
		[Test]
		public void ToString_ZeroYearsZeroMonthsTenDays_ReturnsValidString()
		{
			Sentence s = new Sentence();
			s.SetSentance(0,0,10);
			string str = s.ToString();
			Assert.AreEqual("Fängelse 10 DAGAR", str, "error!");
		}
		
		[Test]
		[ExpectedException(typeof(InvalidOperationException),
			ExpectedMessage = "Sentences must be at least 1 DAY!")]
		public void SetSentence_0_0_0_ThrowsException()
		{
			Sentence s = new Sentence();
			s.SetSentance(0,0,0);
		}	
	}
}
