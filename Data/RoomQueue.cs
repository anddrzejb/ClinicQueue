using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicQueue.Data
{
    public class RoomQueue 
    {
        public event EventHandler OnLineChange;

        private readonly string _officeCode;
        private string currentPatient;

        public int OfficeId { get; private set; }
        public System.Collections.Generic.SortedList<int, string> Line { get; set; }

        public int CurrentKey { get; private set; } = 0;
        public string CurrentPatient
        {
            get { return currentPatient?? "No patient added"; }
            private set { currentPatient = value; }
        }

        public string NextPatient
        {
            get
            {
                if (Line.Count > 0 && CurrentKey == 0)
                    return Line.First().Value;
                    
                if (Line.Count > 1)
                   return Line.ElementAt(1).Value;

                return "No next patient added";
            }
        }

        public string LastPatient
        {
            get
            {
                if (Line.Count > 0)
                    return Line.Last().Value;
                return "No patient added";
            }
        }

        public RoomQueue(int officeId, string officeCode)
        {
            OfficeId = officeId;
            _officeCode = officeCode;
            Line = new SortedList<int, string>();
        }

        public void AddNewPatient(string code = "", int order = 0)
        {
            if (string.IsNullOrEmpty(code))
            {
                code = _officeCode;
            }
            if (order == 0)
            {
                if (Line.Count > 0)
                    order = Line.Last().Key;
                else if (CurrentKey > 0)
                    order = CurrentKey;
            }
            code = $"{code}{++order}";
            Line.Add(order, code);
            OnLineChange(this, EventArgs.Empty);
        }

        public void MoveNext()
        {
            if (Line.Count > 0)
            {
                if (CurrentKey > 0)
                    Line.Remove(CurrentKey);
                if (Line.Count > 0)
                {
                    CurrentKey = Line.First().Key;
                    CurrentPatient = Line[CurrentKey];
                }

                OnLineChange(this, EventArgs.Empty);
            }
        }

    }
}
