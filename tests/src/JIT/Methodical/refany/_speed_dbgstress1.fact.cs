using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__speed_dbgstress1__speed_dbgstress1_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _refany__speed_dbgstress1__speed_dbgstress1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_speed_dbgstress1\\_speed_dbgstress1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
