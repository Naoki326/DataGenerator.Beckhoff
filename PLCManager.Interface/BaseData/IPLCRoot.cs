using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlcCore.Data;

namespace PlcCore.Data
{

    public interface IPLCRoot : IBaseData
    {
        void AddToNotifyCircle(IBaseData node);

        void AddToNotifyCircles(IEnumerable<IBaseData> nodes);


        void StartCircle();

        void StopCircle();

        void SetInterval(int interval);

        void Connect(string ip, int port);

        void Disconnect();

    }
}
