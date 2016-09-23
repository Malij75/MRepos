/*
 * Erstellt mit SharpDevelop.
 * Benutzer: xv8887a
 * Datum: 08.09.2016
 * Zeit: 15:52
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;


namespace ProjeckEditor.Helper
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Projects
	{
		public string ProjectsSorce {get;set;}
//		public List<string> ProjectList
//		{
//			get;
//			
//								
//		}
		
		public void Class1()
		{
		}
	}
		class ProjectCollection
	{
		private string _path;
		public ProjectCollection(string path)
		{
			if (_path == null)
				throw new ArgumentNullException("path");
			this._path = path;
			
		}
		public string Path 
		{
			get	{return _path;}
			set {_path = value;}
		
		}
		public List<Package> PackageList
		{get 
			{return GetPackageList(_path);}
		}
		
			
			
		private List<Package> GetPackageList(string path)
		{  List<Package> _lpack = new List<Package>();
			DirectoryInfo _dirs =new DirectoryInfo(path);
			
			foreach (var _dir  in _dirs.GetDirectories()) {
				foreach (var  _fi in _dir.EnumerateFiles("ruv_isis.ini",SearchOption.TopDirectoryOnly))  {
					
					_lpack.Add( new Package() {Path=_fi.Directory.FullName,Name= _fi.Directory.Name} );
				};
			}
			return _lpack;
		}
		
		
	}
	class Package	
	{
		public string Name {get;set;}
		public string Path {get;set;}
		public override string ToString()
		{
			return string.Format("[Package Name={0}, Path={1}]", Name, Path); 
		}

	}
}
