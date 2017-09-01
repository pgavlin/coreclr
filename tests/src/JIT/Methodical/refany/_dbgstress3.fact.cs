using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _refany__dbgstress3__dbgstress3_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _refany__dbgstress3__dbgstress3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_dbgstress3\\_dbgstress3.cmd");
        }
    }
}
