using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_compiler_FilterToHandler_FilterToHandler_
    {
        [Fact]
        public void _coverage_compiler_FilterToHandler_FilterToHandler_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\compiler\\FilterToHandler\\FilterToHandler.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
