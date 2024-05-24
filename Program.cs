using System;

namespace EPICSWrapper
{
    class Program
    {
        static void Main()
        {
            EPICSProdClassWrapper wrapper = new EPICSProdClassWrapper();

            // Set the LoginProfileName property with the desired value
            string loginProfile = "MyEPICSLoginProfile.xml";
            wrapper.LoginProfileName = loginProfile;

            // Retrieve the LoginProfileName property and write it to the console
            string retrievedProfileName = wrapper.LoginProfileName;
            Console.WriteLine(retrievedProfileName);
        }
    }
}