using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_system
{
    public class _collections_generic_hashset_Regression_Dev10_624201_Regression_Dev10_624201_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _collections_generic_hashset_Regression_Dev10_624201_Regression_Dev10_624201_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\system\\collections\\generic\\hashset\\Regression_Dev10_624201\\Regression_Dev10_624201.cmd");
        }
    }
}
