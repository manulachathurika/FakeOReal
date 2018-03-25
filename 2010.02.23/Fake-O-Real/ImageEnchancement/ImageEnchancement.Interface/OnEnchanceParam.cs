using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FakeOReal.ImageEnchancement.Interface
{
    public class OnEnchanceParam : EventArgs
    {
       private int _param1;
       public int Param1 { get { return _param1; } }
       private int _param2;
       public int Param2 { get { return _param2; } }
       private int _param3;
       public int Param3 { get { return _param3; } }       
       public OnEnchanceParam(int p1, int p2, int p3) { _param1 = p1; _param2 = p2; _param3 = p3;  } 
    }
}
