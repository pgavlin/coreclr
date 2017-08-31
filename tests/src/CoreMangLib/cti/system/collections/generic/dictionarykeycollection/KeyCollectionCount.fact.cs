using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionarykeycollection_KeyCollectionCount_KeyCollectionCount_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionarykeycollection_KeyCollectionCount_KeyCollectionCount_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionarykeycollection\\KeyCollectionCount\\KeyCollectionCount.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
