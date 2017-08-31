using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _regressions_576463_576463_576463_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_576463_576463_576463_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\576463\\576463\\576463.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
