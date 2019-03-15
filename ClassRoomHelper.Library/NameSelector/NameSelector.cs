using System;
using System.IO;
using System.Diagnostic;
using System.Threading;
using System.Collections;

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
                reflexs.AddItem(it.Key);
            }
            studentNumber=names.Count();
        }
        public (int,string) ChooseRandomly(){
            Random r=new Random();
            int key= reflexs[r.Next(0,studentNumber-1)];
            return (key,names[key]);
        }
    }
}