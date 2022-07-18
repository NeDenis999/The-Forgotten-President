using UnityEngine;

namespace Code.Services
{
    public class UnityDebugLogService : ILogService
    {
        public void LogMessage(string message)
        {
            Debug.Log(message);
        }
    }
}