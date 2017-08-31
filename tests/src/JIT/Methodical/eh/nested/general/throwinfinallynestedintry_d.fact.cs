using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_throwinfinallynestedintry_d_throwinfinallynestedintry_d_
    {
        [Fact]
        public void _eh_nested_general_throwinfinallynestedintry_d_throwinfinallynestedintry_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\throwinfinallynestedintry_d\\throwinfinallynestedintry_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
