using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _regressions_beta2_437017_437017_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_beta2_437017_437017_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\beta2\\437017\\437017.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
