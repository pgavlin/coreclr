using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__speed_dbgvirtcall__speed_dbgvirtcall_
    {
        [Fact]
        public void _refany__speed_dbgvirtcall__speed_dbgvirtcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_speed_dbgvirtcall\\_speed_dbgvirtcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
