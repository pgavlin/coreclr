using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _refany__relstress3__relstress3_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _refany__relstress3__relstress3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_relstress3\\_relstress3.cmd");
        }
    }
}
