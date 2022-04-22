using Areas;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace L8_Unit_Tests
{
    class ShapeTests
    {
       [Test]
        public void CircleArea()
        {
            double radius = 4;
            double expectedArea = 50.27;

            Circle c = new Circle(radius);

            double actualArea = Math.Round(c.Area(),2);

            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        public void CirclePer()
        {
            double radius = 4;
            double expectedPer = 25.13;

            Circle c = new Circle(radius);

            double actualPer = Math.Round(c.Perimiter(), 2);

            Assert.That(actualPer, Is.EqualTo(expectedPer));
        }


        [Test]
        public void RectArea()
        {
            double width = 2;
            double height = 4;
            double expectedArea = 8;

            Rectangle r = new Rectangle(width, height);

            double actualArea = Math.Round(r.Area(), 2);

            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        public void RectPer()
        {
            double width = 5;
            double height = 10;
            double expectedPer = 30;

            Rectangle r = new Rectangle(width, height);

            double actualPer= Math.Round(r.Perimiter(), 2);

            Assert.That(actualPer, Is.EqualTo(expectedPer)) ;
        }

        [Test]
        public void TiangleArea()
        {
            double s1 = 2;
            double s2 = 4;
            double s3 = 3;
            double expectedArea = 2.905;

            Triangle t = new Triangle(s1, s2, s3);
            double actualArea = Math.Round(t.Area(), 3);

            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        public void TianglePerm()
        {
            double s1 = 2;
            double s2 = 4;
            double s3 = 3;
            double expectedPer = 9;

            Triangle r = new Triangle(s1, s2,s3);

            double actualPer = Math.Round(r.Perimiter(), 3);

            Assert.That(actualPer, Is.EqualTo(expectedPer));
        }
    }
}
