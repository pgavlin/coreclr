using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionary_DictionaryICollectionCopyTo2_DictionaryICollectionCopyTo2_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionary_DictionaryICollectionCopyTo2_DictionaryICollectionCopyTo2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionary\\DictionaryICollectionCopyTo2\\DictionaryICollectionCopyTo2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
