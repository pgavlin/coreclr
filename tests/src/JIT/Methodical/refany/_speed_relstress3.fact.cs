using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__speed_relstress3__speed_relstress3_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _refany__speed_relstress3__speed_relstress3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_speed_relstress3\\_speed_relstress3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
