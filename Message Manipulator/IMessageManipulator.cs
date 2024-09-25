using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_Manipulator
{
    //IMessageManipulator Interface requires a single function Manipulate(msg:string) -> string) which takes a message as input and outputs the manipulated message.
    internal interface IMessageManipulator
    {
        void Manipulate(string msg);
    }
}
