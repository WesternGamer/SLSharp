using SLSharp.Enums;

namespace SLSharp
{
    public static class ResultCheck
    {
        // Equivalent to SL_CHECK(f): call f(), return early if result not eOk
        public static Result Check(Func<Result> func)
        {
            var r = func();
            if (r != Result.eOk)
                return r;
            return Result.eOk;
        }

        // Equivalent to SL_FAILED(r, f): assign and check if failure
        public static bool Failed(out Result r, Func<Result> func)
        {
            r = func();
            return r != Result.eOk;
        }

        // Equivalent to SL_SUCCEEDED(r, f): assign and check if success
        public static bool Succeeded(out Result r, Func<Result> func)
        {
            r = func();
            return r == Result.eOk;
        }
    }
}
