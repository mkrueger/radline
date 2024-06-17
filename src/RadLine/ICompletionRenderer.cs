using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadLine
{
    public interface ICompletionRenderer
    {
        void RenderLine(LineBuffer buffer);
    }
}
