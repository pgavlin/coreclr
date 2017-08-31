using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_seh__dbgfault__dbgfault_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_seh__dbgfault__dbgfault_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\seh\\_dbgfault\\_dbgfault.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
