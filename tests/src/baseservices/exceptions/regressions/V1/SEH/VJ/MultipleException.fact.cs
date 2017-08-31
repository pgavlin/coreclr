using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _regressions_V1_SEH_VJ_MultipleException_MultipleException_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_VJ_MultipleException_MultipleException_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\VJ\\MultipleException\\MultipleException.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
