using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictvalcollenum_ValueCollectionEnumeratorIEnumeratorCurrent_ValueCollectionEnumeratorIEnumeratorCurrent_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictvalcollenum_ValueCollectionEnumeratorIEnumeratorCurrent_ValueCollectionEnumeratorIEnumeratorCurrent_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictvalcollenum\\ValueCollectionEnumeratorIEnumeratorCurrent\\ValueCollectionEnumeratorIEnumeratorCurrent.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
