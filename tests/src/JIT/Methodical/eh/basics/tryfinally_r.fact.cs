using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_tryfinally_r_tryfinally_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryfinally_r_tryfinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfinally_r\\tryfinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
