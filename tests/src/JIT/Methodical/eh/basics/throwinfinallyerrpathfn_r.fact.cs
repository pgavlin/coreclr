using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_throwinfinallyerrpathfn_r_throwinfinallyerrpathfn_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwinfinallyerrpathfn_r_throwinfinallyerrpathfn_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwinfinallyerrpathfn_r\\throwinfinallyerrpathfn_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
