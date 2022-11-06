using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1
{
    internal class Angle
    {
        int gradus;
        int minute;
        int sec;
        int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {

                gradus = value;
            }
        }
        int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                Gradus += value / 60;
                minute = value % 60;
            }
        }
        int Sec
        {
            get
            {
                return minute;
            }
            set
            {
                Gradus += value / 60;
                sec = value % 60;
            }
        }
        public Angle(int gradus, int minute, int sec)
        {
            this.Gradus = gradus;
            this.Minute = minute;
            this.Sec = sec;
        }
        public double ToRadian()
        {
            return (gradus * 60 * 60 + minute * 60.0 + sec)*Math.PI/(3600*180);
        }
    }
}
