using System;
using System.IO;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

namespace ClassRoomHelper.Library.NameSelector{
    public class NameSelector{
        private int studentNumber;
        private Dictionary<long,string> names;
        private List<long> reflexs;
        public NameSelector(Dictionary<long,string> data){
            names=data;
            reflexs=new List<long>();
            foreach (var it in names)
            {
                reflexs.Add(it.Key);
            }
            studentNumber=names.Count;
        }
        public (long,string) ChooseRandomly(){
            Random r=new Random();
            long key= reflexs[r.Next(0,studentNumber-1)];
            return (key,names[key]);
        }
    }
}