using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _regressions_V1_SEH_VJ_RecursiveException_RecursiveException_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_VJ_RecursiveException_RecursiveException_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\VJ\\RecursiveException\\RecursiveException.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
