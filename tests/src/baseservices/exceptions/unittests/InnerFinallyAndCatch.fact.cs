using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _unittests_InnerFinallyAndCatch_InnerFinallyAndCatch_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_InnerFinallyAndCatch_InnerFinallyAndCatch_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\InnerFinallyAndCatch\\InnerFinallyAndCatch.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
