using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen1
{
    struct History
    {
        public int value;
        public int x;
        public int y;
        public History(int value,int x,int y)
        {
            this.value = value;
            this.x = x;
            this.y = y;
            //this.pyatnashka = pyatnashka;
        }
    }
    class Game3 : Game2
    {
        public readonly List<History> history;
        public Game3(params int[] mas) : base(mas)
        {
            history = new List<History>();
        }
        public bool ToSaveAShiftOrImpossible(int value)
        {
            if (base.ShiftOrImpossible(value))
            {
                history.Add(new History(value, base.GetLocation(value).x,base.GetLocation(value).y));
                return true;
            }
            else return false;
        }
        public void ToDeleteLastShift()
        {
            base.ShiftOrImpossible(history.Last().value);
            history.Remove(history.Last());
        }
        public void ToPrintAHistory()
        {
            foreach (var i in history)
            {
                Console.WriteLine("Значение {0},Координаты{1},{2}",i.value,i.x,i.y);
            }
        }
        
    }
}
