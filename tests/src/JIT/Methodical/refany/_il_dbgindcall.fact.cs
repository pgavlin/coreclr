using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__il_dbgindcall__il_dbgindcall_
    {
        [Fact]
        public void _refany__il_dbgindcall__il_dbgindcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_dbgindcall\\_il_dbgindcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
