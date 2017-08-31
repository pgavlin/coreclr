using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_throwinfinallynestedintry_r_throwinfinallynestedintry_r_
    {
        [Fact]
        public void _eh_nested_general_throwinfinallynestedintry_r_throwinfinallynestedintry_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\throwinfinallynestedintry_r\\throwinfinallynestedintry_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
