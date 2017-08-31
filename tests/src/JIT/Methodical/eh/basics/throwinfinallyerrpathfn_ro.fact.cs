using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_throwinfinallyerrpathfn_ro_throwinfinallyerrpathfn_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwinfinallyerrpathfn_ro_throwinfinallyerrpathfn_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwinfinallyerrpathfn_ro\\throwinfinallyerrpathfn_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
