using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionary_DictionaryICollectionIsReadOnly2_DictionaryICollectionIsReadOnly2_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionary_DictionaryICollectionIsReadOnly2_DictionaryICollectionIsReadOnly2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionary\\DictionaryICollectionIsReadOnly2\\DictionaryICollectionIsReadOnly2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
