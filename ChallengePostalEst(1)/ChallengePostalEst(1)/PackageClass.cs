using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengePostalEst_1_
{
    public class PackageClass
    {
        double hight, width, length, transport, costToSend;
        

        public void CreatePackage(double height_, double width_, double length_) {
            hight = height_;
            width = width_;
            length = length_;

        }

        public void SetTrasport(double x) { transport = x; }
        public void SetCostToSend(double x) { costToSend = x; }

        public double GetHeight() { return hight; }
        public double GetWidth() { return width; }
        public double GetLength() { return length; }
        public double GetCost() { return costToSend; }

        //nextday = 1, air = 2 ground = 3 
        public double GetTransport() { return transport; }




    }
}