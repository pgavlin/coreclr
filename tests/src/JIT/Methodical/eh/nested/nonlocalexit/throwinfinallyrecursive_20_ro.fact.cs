using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_nonlocalexit_throwinfinallyrecursive_20_ro_throwinfinallyrecursive_20_ro_
    {
        [Fact]
        public void _eh_nested_nonlocalexit_throwinfinallyrecursive_20_ro_throwinfinallyrecursive_20_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nonlocalexit\\throwinfinallyrecursive_20_ro\\throwinfinallyrecursive_20_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
