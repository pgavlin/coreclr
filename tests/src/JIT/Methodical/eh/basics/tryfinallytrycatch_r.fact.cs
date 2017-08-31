using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_tryfinallytrycatch_r_tryfinallytrycatch_r_
    {
        [Fact]
        public void _eh_basics_tryfinallytrycatch_r_tryfinallytrycatch_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfinallytrycatch_r\\tryfinallytrycatch_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
