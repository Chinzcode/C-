using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace GETStudent
{
    internal class StudentStatus
    {
        private string _currentStatus;
        private readonly List<string> _statusHistory;
        private readonly StatusTransitionRules _statusTransitionRules;

        public StudentStatus()
        {
            _currentStatus = "Har søkt";
            _statusHistory = new List<string> { _currentStatus };
            _statusTransitionRules = new StatusTransitionRules();
        }

        public string GetCurrentStatus()
        {
            return _currentStatus;
        }

        public bool SetCurrentStatus(string newStatus)
        {
            string validateStatus = _statusTransitionRules.IsTransitionAllowed(_currentStatus, newStatus);
            if (_currentStatus != validateStatus)
            {
                _currentStatus = validateStatus;
                _statusHistory.Add(validateStatus);
                return true;
            }
            return false;
        }

        public bool HasHadStatus(string status)
        {
            return _statusHistory.Contains(status);
        }
    }
}