using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__il_dbgrefloc_o2__il_dbgrefloc_o2_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_basic__il_dbgrefloc_o2__il_dbgrefloc_o2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_il_dbgrefloc_o2\\_il_dbgrefloc_o2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
