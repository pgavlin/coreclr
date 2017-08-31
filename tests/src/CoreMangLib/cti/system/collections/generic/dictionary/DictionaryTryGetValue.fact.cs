using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionary_DictionaryTryGetValue_DictionaryTryGetValue_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionary_DictionaryTryGetValue_DictionaryTryGetValue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionary\\DictionaryTryGetValue\\DictionaryTryGetValue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
