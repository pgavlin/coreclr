using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__speed_dbgstress3__speed_dbgstress3_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _refany__speed_dbgstress3__speed_dbgstress3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_speed_dbgstress3\\_speed_dbgstress3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
