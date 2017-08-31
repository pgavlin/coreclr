using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__dbgvirtcall__dbgvirtcall_
    {
        [Fact]
        public void _refany__dbgvirtcall__dbgvirtcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_dbgvirtcall\\_dbgvirtcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
