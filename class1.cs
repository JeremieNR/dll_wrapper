using System;
using EPICS_Link; 
using System.Runtime.InteropServices;

namespace EPICSWrapper
{
    public class EPICSProdClassWrapper
    {
        private EpicsProdClass _epicsProdClass;
        public EPICSProdClassWrapper()
        {
            _epicsProdClass = new EpicsProdClass();
        }
        public string LoginProfileName
        {
            get => _epicsProdClass.LoginProfileName;
            set => _epicsProdClass.LoginProfileName = value;
        }
        public string TraceFilePath
        {
            get => _epicsProdClass.TraceFilePath;
            set => _epicsProdClass.TraceFilePath = value;
        }
        public int ErrorCode => _epicsProdClass.ErrorCode;
        public string ErrorText => _epicsProdClass.ErrorText;

        // Import the GetNextProdNum function from the DLL
        [DllImport("EpicsLink.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int InitializeConnection();
        public int InitializeConnectionFunc()
        {
            try {
                return InitializeConnection();
            } catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
                return -1; // Error Code Return
            }
        }
    }
}
