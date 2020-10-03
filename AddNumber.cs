using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLogDemo
{
    public class AddNumber
    {
        NLogService NLog = new NLogService();
        public int Sum(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                NLog.LogDebug("Debug Successful : Sum()");
                NLog.LogError("Expecting null values");
                NLog.LogWarn("a & b shouldnot be equal to 0");
            }
                int c = a + b;
                NLog.LogDebug("Debug Successful : Sum()");
                NLog.LogInfo("Sum method passed, Result" + c);
                return c;
            
        }
    }
}
