using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_tryfaulttrycatchfn_d_tryfaulttrycatchfn_d_
    {
        [Fact]
        public void _eh_basics_tryfaulttrycatchfn_d_tryfaulttrycatchfn_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfaulttrycatchfn_d\\tryfaulttrycatchfn_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
