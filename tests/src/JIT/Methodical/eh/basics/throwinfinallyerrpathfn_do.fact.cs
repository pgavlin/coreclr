using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_throwinfinallyerrpathfn_do_throwinfinallyerrpathfn_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwinfinallyerrpathfn_do_throwinfinallyerrpathfn_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwinfinallyerrpathfn_do\\throwinfinallyerrpathfn_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
