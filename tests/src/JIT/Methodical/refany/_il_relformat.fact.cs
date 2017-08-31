using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__il_relformat__il_relformat_
    {
        [OuterLoop]
        [Fact]
        public void _refany__il_relformat__il_relformat_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_relformat\\_il_relformat.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
