using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionary_DictionaryContainsValue_DictionaryContainsValue_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionary_DictionaryContainsValue_DictionaryContainsValue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionary\\DictionaryContainsValue\\DictionaryContainsValue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
