using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__il_dbgrefloc_c__il_dbgrefloc_c_
    {
        [Fact]
        public void _explicit_basic__il_dbgrefloc_c__il_dbgrefloc_c_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_il_dbgrefloc_c\\_il_dbgrefloc_c.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
