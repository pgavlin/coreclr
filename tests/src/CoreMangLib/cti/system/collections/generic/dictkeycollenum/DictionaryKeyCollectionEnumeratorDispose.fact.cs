using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictkeycollenum_DictionaryKeyCollectionEnumeratorDispose_DictionaryKeyCollectionEnumeratorDispose_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictkeycollenum_DictionaryKeyCollectionEnumeratorDispose_DictionaryKeyCollectionEnumeratorDispose_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictkeycollenum\\DictionaryKeyCollectionEnumeratorDispose\\DictionaryKeyCollectionEnumeratorDispose.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
