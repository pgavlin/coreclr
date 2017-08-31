using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_nonlocalexit_throwinfinallynestedintry_30_r_throwinfinallynestedintry_30_r_
    {
        [Fact]
        public void _eh_nested_nonlocalexit_throwinfinallynestedintry_30_r_throwinfinallynestedintry_30_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nonlocalexit\\throwinfinallynestedintry_30_r\\throwinfinallynestedintry_30_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
