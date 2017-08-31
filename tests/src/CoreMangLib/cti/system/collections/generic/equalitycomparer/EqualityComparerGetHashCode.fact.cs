using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_equalitycomparer_EqualityComparerGetHashCode_EqualityComparerGetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_equalitycomparer_EqualityComparerGetHashCode_EqualityComparerGetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\equalitycomparer\\EqualityComparerGetHashCode\\EqualityComparerGetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
