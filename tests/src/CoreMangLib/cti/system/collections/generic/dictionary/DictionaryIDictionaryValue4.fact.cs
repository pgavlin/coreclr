using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionary_DictionaryIDictionaryValue4_DictionaryIDictionaryValue4_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionary_DictionaryIDictionaryValue4_DictionaryIDictionaryValue4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionary\\DictionaryIDictionaryValue4\\DictionaryIDictionaryValue4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
