using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictkeycollenum_DictionaryKeyCollectionEnumeratorMoveNext_DictionaryKeyCollectionEnumeratorMoveNext_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictkeycollenum_DictionaryKeyCollectionEnumeratorMoveNext_DictionaryKeyCollectionEnumeratorMoveNext_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictkeycollenum\\DictionaryKeyCollectionEnumeratorMoveNext\\DictionaryKeyCollectionEnumeratorMoveNext.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
