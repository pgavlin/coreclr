using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_icollection_ICollectionCopyTo_ICollectionCopyTo_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_icollection_ICollectionCopyTo_ICollectionCopyTo_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\icollection\\ICollectionCopyTo\\ICollectionCopyTo.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
