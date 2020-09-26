using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE_Personnel_System
{
    abstract class BaseEntity
    {
        public abstract void SaveData();

        public abstract void GetData();
    }
}
