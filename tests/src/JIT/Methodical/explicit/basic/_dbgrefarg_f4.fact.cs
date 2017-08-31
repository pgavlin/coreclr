using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__dbgrefarg_f4__dbgrefarg_f4_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_basic__dbgrefarg_f4__dbgrefarg_f4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_dbgrefarg_f4\\_dbgrefarg_f4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
