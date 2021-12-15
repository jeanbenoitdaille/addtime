    using System;
     
    namespace Coding.Exercise
    {
        public struct Time
        {
            public int Hours { get; set; }
            public int Minutes { get; set; }
     
            public Time(int h, int m)
            {
                Hours = h;
                Minutes = m;
            }
     
            public static Time operator +(Time a, Time b)
            {
                int count = 0;
                int r = 0;
                if(b.Minutes + a.Minutes >= 60)
                {
                    var div = (b.Minutes + a.Minutes) / 60;
                    count = div;
                    r = (b.Minutes + a.Minutes) - (count * 60);
                    return new Time(a.Hours + count, r);
                }else{
                    return new Time(a.Hours, a.Minutes + b.Minutes);
                }
            }
            public void Display()
            {
                Console.WriteLine(string.Format("Il est {0} heures et {1} minutes", this.Hours, this.Minutes));
            }
        }
    }