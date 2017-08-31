using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictkeycollenum_KeyCollectionEnumeratorIEnumeratorCurrent_KeyCollectionEnumeratorIEnumeratorCurrent_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictkeycollenum_KeyCollectionEnumeratorIEnumeratorCurrent_KeyCollectionEnumeratorIEnumeratorCurrent_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictkeycollenum\\KeyCollectionEnumeratorIEnumeratorCurrent\\KeyCollectionEnumeratorIEnumeratorCurrent.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
