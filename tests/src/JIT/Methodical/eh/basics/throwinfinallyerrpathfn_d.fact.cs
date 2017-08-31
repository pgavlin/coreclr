using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_throwinfinallyerrpathfn_d_throwinfinallyerrpathfn_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwinfinallyerrpathfn_d_throwinfinallyerrpathfn_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwinfinallyerrpathfn_d\\throwinfinallyerrpathfn_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
