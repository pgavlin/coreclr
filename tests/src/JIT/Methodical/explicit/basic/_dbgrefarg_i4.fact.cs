using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__dbgrefarg_i4__dbgrefarg_i4_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_basic__dbgrefarg_i4__dbgrefarg_i4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_dbgrefarg_i4\\_dbgrefarg_i4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
