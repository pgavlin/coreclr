using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionary_DictionaryIDictionaryKeys2_DictionaryIDictionaryKeys2_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionary_DictionaryIDictionaryKeys2_DictionaryIDictionaryKeys2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionary\\DictionaryIDictionaryKeys2\\DictionaryIDictionaryKeys2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
