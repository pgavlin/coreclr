using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionary_DictionaryICollectionIsSynchronized_DictionaryICollectionIsSynchronized_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionary_DictionaryICollectionIsSynchronized_DictionaryICollectionIsSynchronized_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionary\\DictionaryICollectionIsSynchronized\\DictionaryICollectionIsSynchronized.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
