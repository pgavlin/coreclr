using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__relvirtcall__relvirtcall_
    {
        [Fact]
        public void _refany__relvirtcall__relvirtcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_relvirtcall\\_relvirtcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
