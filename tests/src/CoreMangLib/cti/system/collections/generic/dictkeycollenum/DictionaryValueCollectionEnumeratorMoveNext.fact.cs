using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictkeycollenum_DictionaryValueCollectionEnumeratorMoveNext_DictionaryValueCollectionEnumeratorMoveNext_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictkeycollenum_DictionaryValueCollectionEnumeratorMoveNext_DictionaryValueCollectionEnumeratorMoveNext_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictkeycollenum\\DictionaryValueCollectionEnumeratorMoveNext\\DictionaryValueCollectionEnumeratorMoveNext.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
