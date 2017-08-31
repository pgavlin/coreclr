using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__il_relstress2__il_relstress2_
    {
        [OuterLoop]
        [Fact]
        public void _refany__il_relstress2__il_relstress2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_relstress2\\_il_relstress2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
