using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IDataDevice
    {
        string DeviceID { get; set; }
        string DeviceType { get; set; }
        string DeviceName { get; set; }
        string Value { get; set; }
        string DateGathered { get; set; }
        string TimeGathered { get; set; }
    }
}
