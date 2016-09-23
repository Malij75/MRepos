/*
 * Erstellt mit SharpDevelop.
 * Benutzer: xv8887a
 * Datum: 22.09.2016
 * Zeit: 16:23
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;

namespace ProjeckEditor.Helper
{
	/// <summary>
	/// Description of Class2.
	/// </summary>
	public static class StringHelper
	{
		public static bool isCommentLine(this string line)
		{	
			char[] commentchars = {'#',';'};
			
			return (line.Trim().IndexOfAny(commentchars) == 0) ? true : false;
			
		}
		
	}
}
