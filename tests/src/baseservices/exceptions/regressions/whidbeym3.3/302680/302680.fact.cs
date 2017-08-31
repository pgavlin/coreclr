using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _regressions_whidbeym3_3_302680_302680_302680_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_whidbeym3_3_302680_302680_302680_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\whidbeym3.3\\302680\\302680\\302680.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
