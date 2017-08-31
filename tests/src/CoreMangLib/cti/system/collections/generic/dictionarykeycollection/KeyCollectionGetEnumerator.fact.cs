using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionarykeycollection_KeyCollectionGetEnumerator_KeyCollectionGetEnumerator_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionarykeycollection_KeyCollectionGetEnumerator_KeyCollectionGetEnumerator_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionarykeycollection\\KeyCollectionGetEnumerator\\KeyCollectionGetEnumerator.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
