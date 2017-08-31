using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictkeycollenum_DictionaryValueCollectionEnumeratorCurrent_DictionaryValueCollectionEnumeratorCurrent_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictkeycollenum_DictionaryValueCollectionEnumeratorCurrent_DictionaryValueCollectionEnumeratorCurrent_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictkeycollenum\\DictionaryValueCollectionEnumeratorCurrent\\DictionaryValueCollectionEnumeratorCurrent.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
