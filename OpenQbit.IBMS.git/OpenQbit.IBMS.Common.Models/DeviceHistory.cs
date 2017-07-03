using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.IBMS.Common.Models
{
    public class DeviceHistory
    {
        public virtual Device DeviceID { set; get; }
        public DateTime DateTime { set; get; }
        public double Value { set; get; }

    }
}
