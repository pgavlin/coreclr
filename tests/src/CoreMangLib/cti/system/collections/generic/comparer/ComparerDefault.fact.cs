using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_comparer_ComparerDefault_ComparerDefault_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_comparer_ComparerDefault_ComparerDefault_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\comparer\\ComparerDefault\\ComparerDefault.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
