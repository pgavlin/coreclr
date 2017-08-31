using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionaryenumerator_DictionaryEnumeratorDispose_DictionaryEnumeratorDispose_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionaryenumerator_DictionaryEnumeratorDispose_DictionaryEnumeratorDispose_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionaryenumerator\\DictionaryEnumeratorDispose\\DictionaryEnumeratorDispose.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
