using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicQueue
{
    public class AppState
    {
        private bool _isAnnoucementMode;

        public event EventHandler AnnoucementMode;

        public bool IsAnnoucementMode
        {
            get { return _isAnnoucementMode; }
            set 
            {
                if (_isAnnoucementMode != value)
                {
                    _isAnnoucementMode = value;
                    AnnoucementMode(this, EventArgs.Empty);
                }
            }
        }
    }
}
