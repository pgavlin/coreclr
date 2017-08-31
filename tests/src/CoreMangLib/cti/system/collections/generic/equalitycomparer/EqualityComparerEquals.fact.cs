using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_equalitycomparer_EqualityComparerEquals_EqualityComparerEquals_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_equalitycomparer_EqualityComparerEquals_EqualityComparerEquals_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\equalitycomparer\\EqualityComparerEquals\\EqualityComparerEquals.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
