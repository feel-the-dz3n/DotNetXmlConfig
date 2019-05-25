using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetXmlConfig.ConsoleTestProgram
{
    [Serializable]
    public class XmlNumbers : XmlConfig
    {
        public string ProgramName = "Program";
        public string TableName = "Test Table";
        public List<XmlNumber> Numbers = new List<XmlNumber>();
    }

    [Serializable]
    public class XmlNumber
    {
        public string Name;
        public string Number;

        public XmlNumber() { }
        public XmlNumber(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public override string ToString() => $"{Name} - {Number}";
    }
}
