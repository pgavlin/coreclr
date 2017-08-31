using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionary_DictionaryComparer_DictionaryComparer_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionary_DictionaryComparer_DictionaryComparer_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionary\\DictionaryComparer\\DictionaryComparer.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
