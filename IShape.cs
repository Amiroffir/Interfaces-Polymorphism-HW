using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIShape
{
     internal interface IShape
    {
        public string color { get; set; }
        public float frameWidth { get; set; }
        
        public int getVertexNum();
        public void roll();

    }


    public class Rectangle : IShape
    {
        public string color { get; set; }
        public float frameWidth { get; set; }
        public float sidesLength { get; set; }
        public float sidesWidth { get; set; }

        public int getVertexNum()
        {
            return 4;
        }
        public void roll() { }
     

    }
    
    public class Circle : IShape
    {
        public string color { get; set; }
        public float frameWidth { get; set; }
        public float radius { get; set; }

        public int getVertexNum()
        {
            return 0;
        }

        public void roll()
        {  
            MessageBox.Show("Circle Rolling");
        }
    }

    public class Triangle : IShape
    {
        public string color { get; set; }
        public float frameWidth { get; set; }
        public float tHeight { get; set; }
        public float baseSide { get; set; }

        public int getVertexNum()
        {
            return 3;
        }

        public void roll() { }


    }

    public class Elipse : IShape
    {
        public string color { get; set; }
        public float frameWidth { get; set; }
        public float radius1 { get; set; }
        public float radius2 { get; set; }


        public int getVertexNum()
        {
            return 0;
        }
        public void roll()
        {
            MessageBox.Show("Elipse Rolling");
        }
    }


    public class Moon : IShape
    {
        public string color { get; set; }
        public float frameWidth { get; set; }
        public float diameter { get; set; }

        public int getVertexNum()
        {
            return 2;
        }
        public void roll()
        {
            MessageBox.Show("Moon Rolling");
        }
    }
}
