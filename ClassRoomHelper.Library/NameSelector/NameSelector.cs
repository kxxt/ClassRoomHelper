using System;
using System.IO;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.ComponentModel;

namespace ClassRoomHelper.Library.NameSelector{
    public class NameSelector{
		private BindingList<string> names;
		public NameSelector()
		{
			names = new BindingList<string>();
		}
		public void Load(string file)
		{
			var re=File.ReadAllLines(file);
			foreach(var x in re)
			{
				names.Add(x);
			}
		}
		public void Save(string file)
		{
			File.WriteAllLines(file,names);
		}
		public BindingList<string> Names { get => this.names;
			set {
				this.names = value;
			}
		}

		public string ChooseRandomly(){
            Random r=new Random();
			if (names.Count == 0)
			{
				return null;
			}
            return names[r.Next(0, names.Count)];
        }
    }
}