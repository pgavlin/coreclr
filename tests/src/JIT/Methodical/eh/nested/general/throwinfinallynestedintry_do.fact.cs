using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_throwinfinallynestedintry_do_throwinfinallynestedintry_do_
    {
        [Fact]
        public void _eh_nested_general_throwinfinallynestedintry_do_throwinfinallynestedintry_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\throwinfinallynestedintry_do\\throwinfinallynestedintry_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
