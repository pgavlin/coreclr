using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _regressions_whidbeym3_3_106011_106011_106011_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_whidbeym3_3_106011_106011_106011_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\whidbeym3.3\\106011\\106011\\106011.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
