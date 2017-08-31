using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__il_dbgrefloc_r8__il_dbgrefloc_r8_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_basic__il_dbgrefloc_r8__il_dbgrefloc_r8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_il_dbgrefloc_r8\\_il_dbgrefloc_r8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
