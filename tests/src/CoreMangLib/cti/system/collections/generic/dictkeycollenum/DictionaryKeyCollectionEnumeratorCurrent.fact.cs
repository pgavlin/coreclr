using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictkeycollenum_DictionaryKeyCollectionEnumeratorCurrent_DictionaryKeyCollectionEnumeratorCurrent_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictkeycollenum_DictionaryKeyCollectionEnumeratorCurrent_DictionaryKeyCollectionEnumeratorCurrent_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictkeycollenum\\DictionaryKeyCollectionEnumeratorCurrent\\DictionaryKeyCollectionEnumeratorCurrent.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
