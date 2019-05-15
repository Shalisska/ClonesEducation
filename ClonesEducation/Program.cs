using ClonesEducation.Services;
using System;

namespace ClonesEducation
{
    class Program
    {
        static void Main(string[] args)
        {
            var _educationService = new EducationService();

            _educationService.StartLearning(0, 20);
            _educationService.ShowProgress();

            Console.ReadKey();
        }
    }
}
