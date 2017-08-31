using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_identity__il_dbgaccum__il_dbgaccum_
    {
        [OuterLoop]
        [Fact]
        public void _VT_identity__il_dbgaccum__il_dbgaccum_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\identity\\_il_dbgaccum\\_il_dbgaccum.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
