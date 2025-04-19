using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Car_app_3._0
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _year;
        private double _odometer;
        private double _kmPerLiter;
        private double _fuelTank;
        private FuelType brændStofType;
        private bool isEngineOn;
        private List<Trip> trips;
        
 
        public Car(string brand, string model, int year, double kmPerLiter, double fuelTank, FuelType fuelType, List<Trip> trips)
        {
            _brand = brand;
            _model = model;
            _year = year;
            _kmPerLiter = kmPerLiter;
            _fuelTank = fuelTank;
            brændStofType = fuelType;
            this.trips = trips;
            _odometer = 0;
            isEngineOn = false;
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public double Odometer
        {
            get { return _odometer; }
            set { _odometer = value; }
        }

        public double KmPerLiter
        {
            get { return _kmPerLiter; }
            set { _kmPerLiter = value; }
        }

        public FuelType BrændStofType
        {
            get { return brændStofType; }
            set { brændStofType = value; }
        }
        public double FuelTank
        {
            get { return _fuelTank; }
            set { _fuelTank = value; }
        }

        public bool IsEngineOn
        {
            get { return isEngineOn; }
            set { isEngineOn = value; }
        }

        public List<Trip> Trips
        {
            get { return trips; }
            set { trips = value; }
        }

        public void ToggleEngine()
        {
            IsEngineOn = !IsEngineOn;
            Console.WriteLine(IsEngineOn ? "Motoren er tændt." : "Motoren er slukket.");
        }

    }
}

