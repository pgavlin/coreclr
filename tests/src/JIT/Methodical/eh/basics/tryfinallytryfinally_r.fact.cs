using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_tryfinallytryfinally_r_tryfinallytryfinally_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryfinallytryfinally_r_tryfinallytryfinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfinallytryfinally_r\\tryfinallytryfinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
