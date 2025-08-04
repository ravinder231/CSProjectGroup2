using System;

namespace CSProjectGroupX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Patient Health Report App -----");

            // Collect user input
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Weight in kg: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Height in cm: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter SYSTOLIC mm Hg (upper number): ");
            int systolic = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter DIASTOLIC mm Hg (lower number): ");
            int diastolic = Convert.ToInt32(Console.ReadLine());

            // Create Patient object
            Patient patient = new Patient(firstName, lastName, weight, height);

            // Show report
            Console.WriteLine();
            patient.DisplayPatientInfo(systolic, diastolic);

            Console.WriteLine("\n--- End of Report ---");
            Console.ReadLine(); // Pause before exit
        }
    }
}
