using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__il_relarray2__il_relarray2_
    {
        [OuterLoop]
        [Fact]
        public void _refany__il_relarray2__il_relarray2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_relarray2\\_il_relarray2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
