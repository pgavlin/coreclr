using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _unittests_InnerFinallyAndCatch_InnerFinallyAndCatch_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_InnerFinallyAndCatch_InnerFinallyAndCatch_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\InnerFinallyAndCatch\\InnerFinallyAndCatch.cmd");
        }
    }
}
