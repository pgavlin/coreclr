using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_iequalitycomparer_IEqualityComparerEquals_IEqualityComparerEquals_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_iequalitycomparer_IEqualityComparerEquals_IEqualityComparerEquals_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\iequalitycomparer\\IEqualityComparerEquals\\IEqualityComparerEquals.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
