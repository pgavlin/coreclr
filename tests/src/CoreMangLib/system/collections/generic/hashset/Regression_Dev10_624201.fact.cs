using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_system
{
    class _collections_generic_hashset_Regression_Dev10_624201_Regression_Dev10_624201_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _collections_generic_hashset_Regression_Dev10_624201_Regression_Dev10_624201_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\system\\collections\\generic\\hashset\\Regression_Dev10_624201\\Regression_Dev10_624201.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
