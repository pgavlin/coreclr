using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionaryvaluecollection_SystemCollectionsICollectionCopyTo_SystemCollectionsICollectionCopyTo_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionaryvaluecollection_SystemCollectionsICollectionCopyTo_SystemCollectionsICollectionCopyTo_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionaryvaluecollection\\SystemCollectionsICollectionCopyTo\\SystemCollectionsICollectionCopyTo.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
