using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DLayoutScriptIDE
{
    public class ErrorPaneRow
    {
        public string Type { get; set; }
        public int? LineNumber { get; set; }
        public string Message { get; set; }

        public ErrorPaneRow(string type, int? lineNumber, string msg)
        {
            Type = type;
            LineNumber = lineNumber;
            Message = msg;
        }
    }
}
