using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_xlang__odbgsin_il_cs__odbgsin_il_cs_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _Boxing_xlang__odbgsin_il_cs__odbgsin_il_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\xlang\\_odbgsin_il_cs\\_odbgsin_il_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
