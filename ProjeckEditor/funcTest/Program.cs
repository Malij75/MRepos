/*
 * Erstellt mit SharpDevelop.
 * Benutzer: xv8887a
 * Datum: 22.09.2016
 * Zeit: 16:31
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.IO;
	using ProjeckEditor.Helper;

namespace funcTest
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			string testline ="tratata";
			char[] commentsym = {'#',';'};
			if (testline.isCommentLine()){
				Console.WriteLine ("is Comment");
			}
			Console.WriteLine (testline.IndexOf('#'));
			// TODO: Implement Functionality Here
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}