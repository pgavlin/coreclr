using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictvalcollenum_DictionaryValueCollectionEnumeratorDispose_DictionaryValueCollectionEnumeratorDispose_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictvalcollenum_DictionaryValueCollectionEnumeratorDispose_DictionaryValueCollectionEnumeratorDispose_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictvalcollenum\\DictionaryValueCollectionEnumeratorDispose\\DictionaryValueCollectionEnumeratorDispose.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
