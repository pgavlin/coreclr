using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_dictionaryentry_DictionaryEntryKey_DictionaryEntryKey_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_dictionaryentry_DictionaryEntryKey_DictionaryEntryKey_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\dictionaryentry\\DictionaryEntryKey\\DictionaryEntryKey.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
