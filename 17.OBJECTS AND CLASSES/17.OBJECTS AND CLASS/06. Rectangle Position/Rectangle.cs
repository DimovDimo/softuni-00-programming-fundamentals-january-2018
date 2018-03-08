using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Rectangle
    {
        public double Left { get; set; }
        public double Top { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        public double Right
        {
            get
            {
                return Left + Width;
            }
        }

        //public bool IsInside(Rectangle rec2)
        //{
        //    return (Left >= rec2.Left && rec2.Right >= Right
        //            && Top >= rec2.Top && rec2.Bottom >= Bottom);
        //}

        public bool IsInside(Rectangle r)
        {
            return (r.Left <= Left) && (r.Right >= Right) &&
            (r.Top <= Top) && (r.Bottom >= Bottom);
        }
    }
}
