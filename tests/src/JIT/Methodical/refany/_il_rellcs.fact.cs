using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__il_rellcs__il_rellcs_
    {
        [Fact]
        public void _refany__il_rellcs__il_rellcs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_rellcs\\_il_rellcs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
