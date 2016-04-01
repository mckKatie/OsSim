using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim
{
    class SimManager
    {
        int clock;
        Dictionary<int, ProcessControlBLock> processes;
        List<Tuple<int, int>> subTimes;


        List<Tuple<int, int>> IOList; //dont know what to call this <outTime, PID>

        public void CheckIOStatus(int currentTime) //check procList for processes ready to be placed in wait queue
        {
            while(true)
            {
                if(IOList[0].Item1 == currentTime)
                {

                }
            }
        }

        public void StartIO(int PID)
        {
            // get PID and compute current time + IO burst duration
            // make this a tuple
            // place in list and sort on outtime
        }
    }
 
}
