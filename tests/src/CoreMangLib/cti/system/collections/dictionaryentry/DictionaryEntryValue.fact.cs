using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_dictionaryentry_DictionaryEntryValue_DictionaryEntryValue_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_dictionaryentry_DictionaryEntryValue_DictionaryEntryValue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\dictionaryentry\\DictionaryEntryValue\\DictionaryEntryValue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
