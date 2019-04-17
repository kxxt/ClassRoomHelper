using System;
using System.IO;
using System.Threading;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;

namespace ClassRoomHelper.Library.NameSelector{
    public class NameSelector{
		Random r = new Random(GetRandomSeed());
		private BindingList<string> names;
		private List<string> N=new List<string>();
		public string NextPerson(string fn)
		{
			if (N == null) return null;
			if (N.Count == 0)
			{
				GenerateSequence(fn);
				ReadSequence(fn);
			}
			int id = r.Next(0,N.Count);
			string ret = N[id];
			N.RemoveAt(id);
			SaveSequence(fn);
			return ret;
		}
		public void GenerateSequence(string fn)
		{
			var str = new List<string>();
			N = new List<string>();
			foreach(var x in names)
			{
				N.Add(x);
			}
			while (N.Count > 0)
			{
				int id=r.Next(0, N.Count);
				str.Add(N[id]);
				N.RemoveAt(id);
			}
			//SaveSequence(fn);
			File.WriteAllLines(fn, str.ToArray(), System.Text.Encoding.UTF8);
		}
		public void ReadSequence(string fn)
		{
			try
			{
				var x=File.ReadAllLines(fn, System.Text.Encoding.UTF8);
				N.AddRange(x);
			}
			catch
			{
				throw;
			}
		}
		public void SaveSequence(string fn)
		{
			try
			{
				File.WriteAllLines(fn, N.ToArray(),Encoding.UTF8);
			}
			catch
			{
				throw;
			}
		}
		public NameSelector()
		{
			names = new BindingList<string>();
		}
		public void Load(string file)
		{
			var re=File.ReadAllLines(file,System.Text.Encoding.UTF8);
			foreach(var x in re)
			{
				names.Add(x);
			}
		}
		public void Save(string file)
		{
			File.WriteAllLines(file,names, System.Text.Encoding.UTF8);
		}
		public BindingList<string> Names { get => this.names;
			set {
				this.names = value;
			}
		}
		static int GetRandomSeed()
		{
			byte[] bytes = new byte[4];
			System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
			rng.GetBytes(bytes);
			return BitConverter.ToInt32(bytes, 0);
		}
		//Random random = new Random(GetRandomSeed());
		public string ChooseRandomly(){
			long tick = DateTime.Now.Ticks;
			//Random r= new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
			
			if (names.Count == 0)
			{
				return null;
			}
            return names[r.Next(0, names.Count)];
        }
    }
}