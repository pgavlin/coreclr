using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_dictionaryentry_DictionaryEntryCtor_DictionaryEntryCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_dictionaryentry_DictionaryEntryCtor_DictionaryEntryCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\dictionaryentry\\DictionaryEntryCtor\\DictionaryEntryCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
