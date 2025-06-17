using System;
using System.Collections.Generic;
using System.Text;

namespace SLSharp.Enums
{
    public enum LogLevel : uint
    {
        //! No logging
        eOff,
        //! Default logging
        eDefault,
        //! Verbose logging
        eVerbose,
        //! Total count
        eCount
    }
}
