using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__il_relrefloc_o__il_relrefloc_o_
    {
        [Fact]
        public void _explicit_basic__il_relrefloc_o__il_relrefloc_o_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_il_relrefloc_o\\_il_relrefloc_o.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
