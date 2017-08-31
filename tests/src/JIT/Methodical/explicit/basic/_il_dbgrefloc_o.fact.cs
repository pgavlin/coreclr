using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__il_dbgrefloc_o__il_dbgrefloc_o_
    {
        [Fact]
        public void _explicit_basic__il_dbgrefloc_o__il_dbgrefloc_o_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_il_dbgrefloc_o\\_il_dbgrefloc_o.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
