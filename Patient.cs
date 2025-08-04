using System;

namespace CSProjectGroupX
{
    public class Patient
    {
        // Private fields
        private string firstName;
        private string lastName;
        private double weight; // in kilograms
        private double height; // in centimetres

        // Public properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        // Constructor
        public Patient(string firstName, string lastName, double weight, double height)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.weight = weight;
            this.height = height;
        }

        // Public method: Blood pressure evaluation
        public string EvaluateBloodPressure(int systolic, int diastolic)
        {
            if (systolic < 120 && diastolic < 80)
                return "NORMAL";
            else if (systolic >= 120 && systolic <= 129 && diastolic < 80)
                return "ELEVATED";
            else if ((systolic >= 130 && systolic <= 139) || (diastolic >= 80 && diastolic <= 89))
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
            else if ((systolic >= 140) || (diastolic >= 90))
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
            else if ((systolic > 180) || (diastolic > 120))
                return "HYPERTENSIVE CRISIS (consult your doctor immediately)";
            else
                return "Invalid blood pressure values.";
        }

        // Private method: Calculate BMI
        private double CalculateBMI()
        {
            double heightInMeters = height / 100.0;
            return weight / (heightInMeters * heightInMeters);
        }

        // Public method: Display full patient information
        public void DisplayPatientInfo(int systolic, int diastolic)
        {
            Console.WriteLine("---- Patient Information ----");
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Height: {Height} cm");

            string bpResult = EvaluateBloodPressure(systolic, diastolic);
            Console.WriteLine($"Blood Pressure Status: {bpResult}");

            double bmiValue = CalculateBMI();
            Console.WriteLine($"BMI Value: {bmiValue:F2}");

            string bmiStatus;
            if (bmiValue >= 25.0)
                bmiStatus = "Overweight";
            else if (bmiValue >= 18.5)
                bmiStatus = "Normal (In the healthy range)";
            else
                bmiStatus = "Underweight";

            Console.WriteLine($"BMI Status: {bmiStatus}");
        }
    }
}
