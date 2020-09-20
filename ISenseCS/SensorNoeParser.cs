using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISenseCS
{
    abstract class ASensorNode
    {
        public CommandInterface _cmdInterface;
        public Dictionary<byte, string> _supportConfig;
        abstract public bool Start();
        abstract public bool Stop();
    }
    class SensorNodeParser:ASensorNode
    {
        public SensorNodeParser()
        {

        }

        public override bool Start()
        {
            throw new NotImplementedException();
        }
        public override bool Stop()
        {
            throw new NotImplementedException();
        }
    }
}
