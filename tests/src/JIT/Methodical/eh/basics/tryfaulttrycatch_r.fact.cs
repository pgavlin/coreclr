using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_tryfaulttrycatch_r_tryfaulttrycatch_r_
    {
        [Fact]
        public void _eh_basics_tryfaulttrycatch_r_tryfaulttrycatch_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfaulttrycatch_r\\tryfaulttrycatch_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
