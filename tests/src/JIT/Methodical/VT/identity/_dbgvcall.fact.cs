using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_identity__dbgvcall__dbgvcall_
    {
        [OuterLoop]
        [Fact]
        public void _VT_identity__dbgvcall__dbgvcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\identity\\_dbgvcall\\_dbgvcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
