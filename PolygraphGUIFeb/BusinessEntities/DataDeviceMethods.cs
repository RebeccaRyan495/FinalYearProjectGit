using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class DataDeviceMethods
    {
        private static IDataDevice dd = null;

        public static IDataDevice GetDataDevice(string DeviceID, string DeviceType, string DeviceName, string Value, string DateGathered, string TimeGathered)
        {
            if (dd != null)  // ie is Factory is primed with an object. 
                return dd;
            else
                return new DataDevice(DeviceID, DeviceType, DeviceName, Value, DateGathered, TimeGathered);
        }
        public static void SetUser(IDataDevice aDD)   // This provides a seam in the factory where I can prime the factory with the user it will then cough up. (for test code) 
        {
            dd = aDD;
        }
    }
}
