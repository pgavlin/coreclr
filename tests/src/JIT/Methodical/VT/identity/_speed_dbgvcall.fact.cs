using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_identity__speed_dbgvcall__speed_dbgvcall_
    {
        [OuterLoop]
        [Fact]
        public void _VT_identity__speed_dbgvcall__speed_dbgvcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\identity\\_speed_dbgvcall\\_speed_dbgvcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
