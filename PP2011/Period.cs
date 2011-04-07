/*
 * Created by SharpDevelop.
 * User: hugo
 * Date: 2011-03-28
 * Time: 18:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace PP2011
{
	/// <summary>
	/// Description of Period.
	/// </summary>
	public class Period
	{
		private List<Permission> m_kPermissions;
		
		public Period()
		{
		}
		
		public void SetPermissions(int pNofPermissions)
		{
			m_kPermissions = new List<Permission>();
			
			for (int i = 0;i<pNofPermissions;i++ )
			{
				m_kPermissions.Add(new Permission());
			}
		}
	}
}
