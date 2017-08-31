using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListICollectionSyncRoot_ListICollectionSyncRoot_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListICollectionSyncRoot_ListICollectionSyncRoot_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListICollectionSyncRoot\\ListICollectionSyncRoot.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
