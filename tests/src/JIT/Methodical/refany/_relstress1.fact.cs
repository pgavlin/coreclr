using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__relstress1__relstress1_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _refany__relstress1__relstress1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_relstress1\\_relstress1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
