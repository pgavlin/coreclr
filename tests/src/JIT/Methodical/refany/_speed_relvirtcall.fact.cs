using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__speed_relvirtcall__speed_relvirtcall_
    {
        [Fact]
        public void _refany__speed_relvirtcall__speed_relvirtcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_speed_relvirtcall\\_speed_relvirtcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
