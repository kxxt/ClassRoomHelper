using System;
using System.IO;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace ClassRoomHelper.Library.NameSelector{
    public class NameSelector{
        private int studentNumber;

        private DictionaryEx<long,string> names;
        private List<long> reflexs;
		public void Test_AddExampleData()
		{
			names.Add(1, "С��");
			names.Add(2, "С��");
			names.Add(3, "С��");
			names.Add(4, "С��");
			names.Add(5, "С��");
			names.Add(6, "����");
			names.Add(7, "������");
			names.Add(8, "Hello");
			names.Add(9, "ASS");
			studentNumber = 9;
			foreach (var it in Names)
			{
				reflexs.Add(it.Key);
			}
		}
		public DictionaryEx<long, string> Names { get => this.names; set => this.names = value; }
		public void Load()
		{
			try
			{
				names=XmlHelper.XMLToObejct<DictionaryEx<long, string>>("names.xml");
			}
			catch(Exception e)
			{
				Log.AppendException("Logs\\nameselector.log",e);
			}
		}
		public void Save()
		{
			try
			{
				var x= XmlHelper.ObjectToXML(names);
				x.Save("names.xml");
			}
			catch (Exception e)
			{
				Log.AppendException("Logs\\nameselector.log", e);
			}
		}
		public NameSelector()
		{
			reflexs = new List<long>();
			names = new DictionaryEx<long, string>();
		}

		public NameSelector(DictionaryEx<long,string> data){
            Names=data;
            reflexs=new List<long>();
            foreach (var it in Names)
            {
                reflexs.Add(it.Key);
            }
            studentNumber=Names.Count;
        }
        public (long,string) ChooseRandomly(){
            Random r=new Random();
            long key= reflexs[r.Next(0,studentNumber)];
            return (key,Names[key]);
        }
    }
}