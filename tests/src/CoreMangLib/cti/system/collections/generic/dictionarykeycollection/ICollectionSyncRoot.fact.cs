using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionarykeycollection_ICollectionSyncRoot_ICollectionSyncRoot_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionarykeycollection_ICollectionSyncRoot_ICollectionSyncRoot_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionarykeycollection\\ICollectionSyncRoot\\ICollectionSyncRoot.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
