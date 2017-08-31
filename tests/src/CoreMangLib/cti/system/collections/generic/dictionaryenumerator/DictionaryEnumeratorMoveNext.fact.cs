using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionaryenumerator_DictionaryEnumeratorMoveNext_DictionaryEnumeratorMoveNext_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionaryenumerator_DictionaryEnumeratorMoveNext_DictionaryEnumeratorMoveNext_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionaryenumerator\\DictionaryEnumeratorMoveNext\\DictionaryEnumeratorMoveNext.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
