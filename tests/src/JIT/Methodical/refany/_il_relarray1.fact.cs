using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__il_relarray1__il_relarray1_
    {
        [OuterLoop]
        [Fact]
        public void _refany__il_relarray1__il_relarray1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_relarray1\\_il_relarray1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
