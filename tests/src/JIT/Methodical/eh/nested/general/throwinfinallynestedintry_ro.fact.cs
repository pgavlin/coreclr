using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_throwinfinallynestedintry_ro_throwinfinallynestedintry_ro_
    {
        [Fact]
        public void _eh_nested_general_throwinfinallynestedintry_ro_throwinfinallynestedintry_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\throwinfinallynestedintry_ro\\throwinfinallynestedintry_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
