using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictvalcollenum_ValueCollectionEnumeratorIEnumeratorReset_ValueCollectionEnumeratorIEnumeratorReset_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictvalcollenum_ValueCollectionEnumeratorIEnumeratorReset_ValueCollectionEnumeratorIEnumeratorReset_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictvalcollenum\\ValueCollectionEnumeratorIEnumeratorReset\\ValueCollectionEnumeratorIEnumeratorReset.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
