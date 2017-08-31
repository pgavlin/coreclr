using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionary_DictionaryICollectionSyncRoot2_DictionaryICollectionSyncRoot2_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionary_DictionaryICollectionSyncRoot2_DictionaryICollectionSyncRoot2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionary\\DictionaryICollectionSyncRoot2\\DictionaryICollectionSyncRoot2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
