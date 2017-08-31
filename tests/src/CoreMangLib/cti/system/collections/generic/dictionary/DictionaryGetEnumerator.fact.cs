using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionary_DictionaryGetEnumerator_DictionaryGetEnumerator_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionary_DictionaryGetEnumerator_DictionaryGetEnumerator_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionary\\DictionaryGetEnumerator\\DictionaryGetEnumerator.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
