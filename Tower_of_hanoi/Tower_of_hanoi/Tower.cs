using System.Collections.Generic;
namespace Tower_of_hanoi
{
    class Tower
    {
        //Inputs
        static Tower temp;
        //Builders
        public Tower()
        {
            //Fathers = new List<Tower>();
            Nuts = new List<Nut>();
            //Left = new List<Nut>();
            //Middle = new List<Nut>();
            //Right = new List<Nut>();
        }
        public Tower(params Nut[] nuts)
        {
            Answer = new List<Tower>();
            Stop = true;
            //Fathers = new List<Tower>();
            Nuts = new List<Nut>();
            //Left = new List<Nut>();
            //Middle = new List<Nut>();
            //Right = new List<Nut>();

            Nuts.AddRange(nuts);
            Left.AddRange(nuts);
            Fathers.AddRange(new Tower[0]);
            for (int i = 0; i < Nuts.Count; i++) Nuts[i] = new Nut(i, this);
            Solver(this);
        }
        //Properties
        public static List<Tower> Answer { get; private set; }
        private static bool Stop { get; set; }
        private static List<Tower> Fathers { get; }
        public List<Nut> Nuts { get; }
        public static List<Nut> Left { get; }
        public static List<Nut> Middle { get; }
        public static List<Nut> Right { get; }
        public object[] tw { get { return new object[3] { Left, Middle, Right }; } }
        //Methods
        private static void Solver(Tower tower)
        {
            if ((Right.Count != tower.Nuts.Count) && Stop)
                for (int i = 0; (i < tower.Nuts.Count) && Stop; i++)
                    for (int j = 0; (j < tower.Nuts[i].Open_ways.Count) && Stop; j++)
                    {
                        temp = new Tower();
                        Fathers.AddRange(Fathers);
                        Fathers.Add(tower);
                        NutEquals(tower);
                        temp.Nuts[i].Culomn =  tower.Nuts[i].Open_ways[j];
                        Mover();
                        temp.Nuts[i].Hight = ((List<Nut>)temp.tw[(int)tower.Nuts[i].Open_ways[j]]).Count - 1;
                        foreach (Nut item in temp.Nuts) item.Get_open_ways();
                        if (Pruning()) Solver(temp);
                    }
            else 
            {
                Stop = false;
                Answer.AddRange(Fathers.ToArray());
                Answer.Add(tower);
            }
        }
        private static void NutEquals(Tower tower)
        {
            temp.Nuts.AddRange(new Nut[tower.Nuts.Count]);
            for (int k = 0; k < tower.Nuts.Count; k++)
            {
                temp.Nuts[k] = new Nut(tower.Nuts[k].Size, temp);
                temp.Nuts[k].Culomn = tower.Nuts[k].Culomn;
                temp.Nuts[k].Hight = tower.Nuts[k].Hight;
            }
        }
        private static void Mover() 
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < temp.Nuts.Count; j++)
                    if (temp.Nuts[j].Culomn == (State)i) ((List<Nut>)temp.tw[i]).Add(temp.Nuts[j]);
        }
        private static bool Pruning() 
        {
            for (int i = 0; i < Fathers.Count - 1; i++)
                if (Fathers[i] == temp)
                {
                    temp = null;
                    return false;
                } 
            return true;
        }
        //Operator Methods
        public static bool operator ==(Tower tower1, Tower tower2) 
        {
            bool Out = true;
            if (tower1.Nuts.Count == tower2.Nuts.Count)
                for (int i = 0; (i < tower1.Nuts.Count) && Out; i++)
                    if (tower1.Nuts[i] == tower2.Nuts[i]) Out = true;
                    else Out = false;
            else Out = false;
            return Out; 
        }
        public static bool operator !=(Tower tower1, Tower tower2) 
        {
            if (tower1 == tower2) return false;
            return true; 
        }
        //End
    }
}
