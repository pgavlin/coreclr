using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionary_DictionaryIDictionaryIsFixedSize2_DictionaryIDictionaryIsFixedSize2_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionary_DictionaryIDictionaryIsFixedSize2_DictionaryIDictionaryIsFixedSize2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionary\\DictionaryIDictionaryIsFixedSize2\\DictionaryIDictionaryIsFixedSize2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
