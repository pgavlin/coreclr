using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionary_DictionaryIDictionaryItem_DictionaryIDictionaryItem_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionary_DictionaryIDictionaryItem_DictionaryIDictionaryItem_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionary\\DictionaryIDictionaryItem\\DictionaryIDictionaryItem.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
