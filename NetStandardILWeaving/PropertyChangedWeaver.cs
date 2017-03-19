using System;
using System.Collections.Generic;
using System.Text;
using Blur;

[assembly: Blur(CleanUp = true)]

namespace NetStandardILWeaving
{
    class PropertyChangedWeaver : BlurVisitor
    {
        public override int Priority => 900;
    }
}
