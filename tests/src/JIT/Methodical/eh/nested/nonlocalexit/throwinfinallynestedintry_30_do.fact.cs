using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_nonlocalexit_throwinfinallynestedintry_30_do_throwinfinallynestedintry_30_do_
    {
        [Fact]
        public void _eh_nested_nonlocalexit_throwinfinallynestedintry_30_do_throwinfinallynestedintry_30_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nonlocalexit\\throwinfinallynestedintry_30_do\\throwinfinallynestedintry_30_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
