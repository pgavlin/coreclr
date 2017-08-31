using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionary_DictionaryAdd_DictionaryAdd_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionary_DictionaryAdd_DictionaryAdd_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionary\\DictionaryAdd\\DictionaryAdd.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
