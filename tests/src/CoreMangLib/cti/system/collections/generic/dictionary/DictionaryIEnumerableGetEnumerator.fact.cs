using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionary_DictionaryIEnumerableGetEnumerator_DictionaryIEnumerableGetEnumerator_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionary_DictionaryIEnumerableGetEnumerator_DictionaryIEnumerableGetEnumerator_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionary\\DictionaryIEnumerableGetEnumerator\\DictionaryIEnumerableGetEnumerator.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
