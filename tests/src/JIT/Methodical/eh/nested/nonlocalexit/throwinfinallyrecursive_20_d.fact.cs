using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_nonlocalexit_throwinfinallyrecursive_20_d_throwinfinallyrecursive_20_d_
    {
        [Fact]
        public void _eh_nested_nonlocalexit_throwinfinallyrecursive_20_d_throwinfinallyrecursive_20_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nonlocalexit\\throwinfinallyrecursive_20_d\\throwinfinallyrecursive_20_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
