using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_comparer_ComparerCompare1_ComparerCompare1_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_comparer_ComparerCompare1_ComparerCompare1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\comparer\\ComparerCompare1\\ComparerCompare1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
