using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__il_relarray3__il_relarray3_
    {
        [Fact]
        public void _refany__il_relarray3__il_relarray3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_relarray3\\_il_relarray3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
