using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_nonlocalexit_throwinfinallynestedintry_30_d_throwinfinallynestedintry_30_d_
    {
        [Fact]
        public void _eh_nested_nonlocalexit_throwinfinallynestedintry_30_d_throwinfinallynestedintry_30_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nonlocalexit\\throwinfinallynestedintry_30_d\\throwinfinallynestedintry_30_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
