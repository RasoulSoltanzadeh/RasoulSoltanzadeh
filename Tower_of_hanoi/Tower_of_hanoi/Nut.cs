using System.Collections.Generic;
namespace Tower_of_hanoi
{
    class Nut
    {
        //Builders
        public Nut() 
        {
            Area = new Tower();
            Culomn = new State();
            Open_ways = new List<State>();
            Size = new int();
            Hight = new int();
        }
        public Nut(int size, Tower tower)   
        {
            if (size < 0) size = 0;
            Area = new Tower();
            Culomn = new State();
            Open_ways = new List<State>();
            Hight = new int();
            Size = new int();
            Area = tower;
            Size = size;
            Culomn = 0;
            Hight = size;
            Get_open_ways();
        }
        //Properties
        private Tower Area { get; set; }
        public int Size { get; set; }
        public State Culomn { get; set; }
        public int Hight { get; set; }
        public List<State> Open_ways { get; set; }
        //Methods
        public void Get_open_ways() 
        {
            if (Hight == (((List<Nut>)Area.tw[(int)Culomn]).Count - 1))
                for (int i = 0; i < 3; i++)
                    if ((i != ((int)Culomn)) && ((((List<Nut>)Area.tw[i]).Count == 0) || (((List<Nut>)Area.tw[i])[((List<Nut>)Area.tw[i]).Count - 1].Size < Size))) Open_ways.Add((State)i);
            Open_ways.Reverse();
        }
        //Operator Methods
        public static bool operator ==(Nut nut1, Nut nut2) 
        {
            if ((nut1.Culomn == nut2.Culomn) && (nut1.Size == nut2.Size) && (nut1.Hight == nut2.Hight)) return true;
            return false;
        }
        public static bool operator !=(Nut nut1, Nut nut2) 
        {
            if (nut1 == nut2) return false;
            return true;
        }        
        //End
    }
}
