using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__il_relrefloc_r4__il_relrefloc_r4_
    {
        [Fact]
        public void _explicit_basic__il_relrefloc_r4__il_relrefloc_r4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_il_relrefloc_r4\\_il_relrefloc_r4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
