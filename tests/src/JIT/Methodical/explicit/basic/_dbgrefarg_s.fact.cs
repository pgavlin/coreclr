using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__dbgrefarg_s__dbgrefarg_s_
    {
        [Fact]
        public void _explicit_basic__dbgrefarg_s__dbgrefarg_s_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_dbgrefarg_s\\_dbgrefarg_s.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
