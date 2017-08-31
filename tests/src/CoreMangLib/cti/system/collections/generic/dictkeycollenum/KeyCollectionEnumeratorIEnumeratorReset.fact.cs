using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictkeycollenum_KeyCollectionEnumeratorIEnumeratorReset_KeyCollectionEnumeratorIEnumeratorReset_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictkeycollenum_KeyCollectionEnumeratorIEnumeratorReset_KeyCollectionEnumeratorIEnumeratorReset_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictkeycollenum\\KeyCollectionEnumeratorIEnumeratorReset\\KeyCollectionEnumeratorIEnumeratorReset.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
