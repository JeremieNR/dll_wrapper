using System;
using EPICS_Link; 

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
    }
}
