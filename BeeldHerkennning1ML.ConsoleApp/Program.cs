// This file was auto-generated by ML.NET Model Builder. 

using System;
using System.Diagnostics;
using BeeldHerkennning1ML.Model;
namespace BeeldHerkennning1

{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine(" Object is not valid for this category.");
            // Add input data
            var input = new ModelInput();
            input.ImageSource = "C:\\Users\\pc-5\\Downloads\\Object-recognition-CIFAR-10-master\\rocva ml.NET images\\autos\\auto1.jpg";

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Debug.WriteLine(result.Prediction);
            Console.WriteLine(result.Prediction);
        }
    }
}