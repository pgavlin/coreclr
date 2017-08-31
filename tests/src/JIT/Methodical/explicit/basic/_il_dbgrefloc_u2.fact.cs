using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__il_dbgrefloc_u2__il_dbgrefloc_u2_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_basic__il_dbgrefloc_u2__il_dbgrefloc_u2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_il_dbgrefloc_u2\\_il_dbgrefloc_u2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
