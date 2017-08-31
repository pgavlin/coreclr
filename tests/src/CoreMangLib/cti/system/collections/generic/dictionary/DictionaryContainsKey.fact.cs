using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionary_DictionaryContainsKey_DictionaryContainsKey_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionary_DictionaryContainsKey_DictionaryContainsKey_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionary\\DictionaryContainsKey\\DictionaryContainsKey.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
