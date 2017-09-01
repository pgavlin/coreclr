using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _unittests_TryCatchInFinally_TryCatchInFinally_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_TryCatchInFinally_TryCatchInFinally_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\TryCatchInFinally\\TryCatchInFinally.cmd");
        }
    }
}
