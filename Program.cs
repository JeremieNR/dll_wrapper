using System;

namespace EPICSWrapper
{
    class Program
    {
        static void Main()
        {
            var epicsWrapper = new EPICSProdClassWrapper();

            // Set properties if needed
            epicsWrapper.LoginProfileName = "sussybaka";
            epicsWrapper.TraceFilePath = @"C:\Temp\trace.log";

            // Call the GetNextProductNumber method
            int Connection_var = epicsWrapper.InitializeConnectionFunc();
            if (Connection_var != -1)
            {
                Console.WriteLine($"Next Product Number: {Connection_var}");
            }
            else
            {
                Console.WriteLine("Failed to get the next product number.");
            }
        }
    }
}