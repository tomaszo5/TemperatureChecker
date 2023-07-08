using System;
using TemperatureChecker.Entities;
using TemperatureChecker.Repositories;
 
namespace TemperatureApp
{
    public class Verifier
    {
        static void WorkVerifier()
        {
            IWorkVerifier workVerifier = new WorkVerifier();
            workVerifier.VerifyWork();
        }
    }
}