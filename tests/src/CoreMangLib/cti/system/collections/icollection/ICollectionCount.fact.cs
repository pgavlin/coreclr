using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_icollection_ICollectionCount_ICollectionCount_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_icollection_ICollectionCount_ICollectionCount_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\icollection\\ICollectionCount\\ICollectionCount.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
