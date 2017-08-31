using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_tryfaulttrycatch_d_tryfaulttrycatch_d_
    {
        [Fact]
        public void _eh_basics_tryfaulttrycatch_d_tryfaulttrycatch_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfaulttrycatch_d\\tryfaulttrycatch_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
