using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_icomparer_IComparerCompare_IComparerCompare_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_icomparer_IComparerCompare_IComparerCompare_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\icomparer\\IComparerCompare\\IComparerCompare.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
