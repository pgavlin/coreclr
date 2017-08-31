using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_comparer_ComparerCompare2_ComparerCompare2_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_comparer_ComparerCompare2_ComparerCompare2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\comparer\\ComparerCompare2\\ComparerCompare2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
