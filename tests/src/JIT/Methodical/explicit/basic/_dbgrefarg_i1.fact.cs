using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__dbgrefarg_i1__dbgrefarg_i1_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_basic__dbgrefarg_i1__dbgrefarg_i1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_dbgrefarg_i1\\_dbgrefarg_i1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
