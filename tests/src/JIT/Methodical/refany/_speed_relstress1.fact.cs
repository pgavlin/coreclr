using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__speed_relstress1__speed_relstress1_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _refany__speed_relstress1__speed_relstress1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_speed_relstress1\\_speed_relstress1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
