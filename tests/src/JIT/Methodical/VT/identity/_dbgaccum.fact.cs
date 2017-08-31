using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_identity__dbgaccum__dbgaccum_
    {
        [OuterLoop]
        [Fact]
        public void _VT_identity__dbgaccum__dbgaccum_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\identity\\_dbgaccum\\_dbgaccum.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
