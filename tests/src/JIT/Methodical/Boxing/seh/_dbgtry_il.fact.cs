using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_seh__dbgtry_il__dbgtry_il_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_seh__dbgtry_il__dbgtry_il_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\seh\\_dbgtry_il\\_dbgtry_il.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
