using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_tryfinallytryfinally_d_tryfinallytryfinally_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryfinallytryfinally_d_tryfinallytryfinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfinallytryfinally_d\\tryfinallytryfinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
