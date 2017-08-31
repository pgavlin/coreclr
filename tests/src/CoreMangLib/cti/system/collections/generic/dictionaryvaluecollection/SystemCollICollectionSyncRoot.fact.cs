using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionaryvaluecollection_SystemCollICollectionSyncRoot_SystemCollICollectionSyncRoot_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionaryvaluecollection_SystemCollICollectionSyncRoot_SystemCollICollectionSyncRoot_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionaryvaluecollection\\SystemCollICollectionSyncRoot\\SystemCollICollectionSyncRoot.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
