using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictkeycollenum_ValueCollectionEnumeratorIEnumeratorReset_ValueCollectionEnumeratorIEnumeratorReset_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictkeycollenum_ValueCollectionEnumeratorIEnumeratorReset_ValueCollectionEnumeratorIEnumeratorReset_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictkeycollenum\\ValueCollectionEnumeratorIEnumeratorReset\\ValueCollectionEnumeratorIEnumeratorReset.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
