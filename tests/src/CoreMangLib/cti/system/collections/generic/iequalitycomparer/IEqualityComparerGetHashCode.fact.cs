using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_iequalitycomparer_IEqualityComparerGetHashCode_IEqualityComparerGetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_iequalitycomparer_IEqualityComparerGetHashCode_IEqualityComparerGetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\iequalitycomparer\\IEqualityComparerGetHashCode\\IEqualityComparerGetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
