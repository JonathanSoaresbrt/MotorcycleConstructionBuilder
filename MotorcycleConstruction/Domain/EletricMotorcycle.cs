﻿using MotorcycleConstruction.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleConstruction.Domain
{
    public class EletricMotorcycle
    {
        public int Id { get; private set; }
        public string Model { get; private set; }
        public string Color { get; private set; }
        public string MaxPower { get; private set; }
        public string MaxTorque { get; private set; }
        public string TopSpeed { get; private set; }
        public string Battery { get; private set; }
        public string OverallWidht { get; private set; }
        public string OverallHeight { get; private set; }
        public string SeatHeight { get; private set; }
        public string WhellBase { get; private set; }
        public string GroudClearance { get; private set; }
        public string DryWeight { get; private set; }
        public DateTime FabricationDate { get; private set; }
        public List<ComponentsMotorcyle> ComponentsMotorcyle { get; private set; }

        public EletricMotorcycle(int id, string model, string color, string maxPower, 
            string maxTorque, string topSpeed, string battery, string overallWidht, 
            string overallHeight, string seatHeight, string whellBase, string groudClearance, 
            string dryWeight, DateTime fabricationDate, List<ComponentsMotorcyle> componentsMotorcyle)
        {
            Id = id;
            Model = model;
            Color = color;
            MaxPower = maxPower;
            MaxTorque = maxTorque;
            TopSpeed = topSpeed;
            Battery = battery;
            OverallWidht = overallWidht;
            OverallHeight = overallHeight;
            SeatHeight = seatHeight;
            WhellBase = whellBase;
            GroudClearance = groudClearance;
            DryWeight = dryWeight;
            FabricationDate = fabricationDate;
            ComponentsMotorcyle = componentsMotorcyle;
        }
    }
}
