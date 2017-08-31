using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _regressions_beta1_347011_347011_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_beta1_347011_347011_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\beta1\\347011\\347011.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
