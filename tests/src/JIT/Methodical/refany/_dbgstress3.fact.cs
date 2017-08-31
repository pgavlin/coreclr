using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__dbgstress3__dbgstress3_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _refany__dbgstress3__dbgstress3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_dbgstress3\\_dbgstress3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
