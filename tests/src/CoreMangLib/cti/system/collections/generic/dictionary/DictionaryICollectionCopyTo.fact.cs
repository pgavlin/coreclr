using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionary_DictionaryICollectionCopyTo_DictionaryICollectionCopyTo_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionary_DictionaryICollectionCopyTo_DictionaryICollectionCopyTo_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionary\\DictionaryICollectionCopyTo\\DictionaryICollectionCopyTo.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
