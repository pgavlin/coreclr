using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_xlang__odbgsin_il_il__odbgsin_il_il_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _Boxing_xlang__odbgsin_il_il__odbgsin_il_il_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\xlang\\_odbgsin_il_il\\_odbgsin_il_il.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
