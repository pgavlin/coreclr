using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_nonlocalexit_throwinfinallyrecursive_20_r_throwinfinallyrecursive_20_r_
    {
        [Fact]
        public void _eh_nested_nonlocalexit_throwinfinallyrecursive_20_r_throwinfinallyrecursive_20_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nonlocalexit\\throwinfinallyrecursive_20_r\\throwinfinallyrecursive_20_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
