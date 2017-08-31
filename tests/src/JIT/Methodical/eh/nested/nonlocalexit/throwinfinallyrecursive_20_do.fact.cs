using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_nonlocalexit_throwinfinallyrecursive_20_do_throwinfinallyrecursive_20_do_
    {
        [Fact]
        public void _eh_nested_nonlocalexit_throwinfinallyrecursive_20_do_throwinfinallyrecursive_20_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nonlocalexit\\throwinfinallyrecursive_20_do\\throwinfinallyrecursive_20_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
