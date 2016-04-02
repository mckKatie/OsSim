using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Pstate { busy, open, stop}

namespace Sim
{
    class Processor
    {
        public Pstate state;
        int PID;
        int burstCompletionTime; // either because burst is completed or quantum reached

        Processor(){
            state = Pstate.open;
        }
        public void CheckStatus(int currentTime)
        {
            if (burstCompletionTime == currentTime)
            {
                state = Pstate.stop;
            }
        }

        public void ContextSwap(int _PID, int _burstCompletionTime) // burst completion time needs to be set to sooner of burst time and quantum in os strategy
        {
            PID = _PID;
            burstCompletionTime = _PID;
            state = Pstate.busy;
        }

        public int FreeProcessor()
        {
            state = Pstate.open;
            return PID;
        }
    }
}
