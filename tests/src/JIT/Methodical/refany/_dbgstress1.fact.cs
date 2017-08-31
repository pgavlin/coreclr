using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__dbgstress1__dbgstress1_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _refany__dbgstress1__dbgstress1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_dbgstress1\\_dbgstress1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
