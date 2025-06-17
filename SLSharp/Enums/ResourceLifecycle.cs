using System;
using System.Collections.Generic;
using System.Text;

namespace SLSharp.Enums
{
    public enum ResourceLifecycle
    {
        //! Resource can change, get destroyed or reused for other purposes after it is provided to SL
        eOnlyValidNow,
        //! Resource does NOT change, gets destroyed or reused for other purposes from the moment it is provided to SL until the frame is presented
        eValidUntilPresent,
        //! Resource does NOT change, gets destroyed or reused for other purposes from the moment it is provided to SL until after the slEvaluateFeature call has returned.
        eValidUntilEvaluate
    }
}
