﻿using OnlineShop.Common.Enums;

namespace OnlineShop.Models.Products.Computers
{
    public class DesktopComputer : Computer
    {
        private  const int OVERALL_PERFORMANCE = 15;
        private double overallPerformance;

        public DesktopComputer(int id, string manufacturer, string model, decimal price) 
            : base(id, manufacturer, model, price, OVERALL_PERFORMANCE)
        {
        }

        public override double OverallPerformance
        {
            get => this.overallPerformance + base.OverallPerformance;
            protected set => this.overallPerformance = value;
        }
    }
}