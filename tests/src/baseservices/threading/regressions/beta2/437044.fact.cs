using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _regressions_beta2_437044_437044_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_beta2_437044_437044_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\beta2\\437044\\437044.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
