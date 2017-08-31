using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__il_dbgrefloc_i4__il_dbgrefloc_i4_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_basic__il_dbgrefloc_i4__il_dbgrefloc_i4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_il_dbgrefloc_i4\\_il_dbgrefloc_i4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
