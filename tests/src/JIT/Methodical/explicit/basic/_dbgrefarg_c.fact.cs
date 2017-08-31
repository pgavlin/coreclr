using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__dbgrefarg_c__dbgrefarg_c_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_basic__dbgrefarg_c__dbgrefarg_c_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_dbgrefarg_c\\_dbgrefarg_c.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
