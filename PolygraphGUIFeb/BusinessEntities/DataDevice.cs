using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class DataDevice: IDataDevice
    {
        #region Instance Properties

        private string deviceID;
        private string deviceType;
        private string deviceName;
        private string values;
        private string dateGathered;
        private string timeGathered;
        #endregion

        public string DeviceID
        {
            get
            {
                return deviceID;
            }
            set
            {
                deviceID = value;
            }
        }

        public string DeviceType
        {
            get
            {
                return deviceType;
            }
            set
            {
                deviceType = value;
            }
        }

        public string DeviceName
        {
            get
            {
                return deviceName;
            }
            set
            {
                deviceName = value;
            }
        }

        public string Value
        {
            get
            {
                return values;
            }
            set
            {
                values = value;
            }
        }

        public string DateGathered
        {
            get
            {
                return dateGathered;
            }
            set
            {
                dateGathered = value;
            }
        }

        public string TimeGathered
        {
            get
            {
                return timeGathered;
            }
            set
            {
                timeGathered = value;
            }
        }
    }
}
