using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_nonlocalexit_throwinfinallynestedintry_30_ro_throwinfinallynestedintry_30_ro_
    {
        [Fact]
        public void _eh_nested_nonlocalexit_throwinfinallynestedintry_30_ro_throwinfinallynestedintry_30_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nonlocalexit\\throwinfinallynestedintry_30_ro\\throwinfinallynestedintry_30_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
