using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_identity__speed_dbgaccum__speed_dbgaccum_
    {
        [OuterLoop]
        [Fact]
        public void _VT_identity__speed_dbgaccum__speed_dbgaccum_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\identity\\_speed_dbgaccum\\_speed_dbgaccum.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
