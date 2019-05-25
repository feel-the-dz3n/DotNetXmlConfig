using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetXmlConfig.ConsoleTestProgram
{
    public class ConfigMan
    {
        public static XmlNumbers Numbers = XmlConfig.Load<XmlNumbers>("numbers.xml", true);
    }
}
