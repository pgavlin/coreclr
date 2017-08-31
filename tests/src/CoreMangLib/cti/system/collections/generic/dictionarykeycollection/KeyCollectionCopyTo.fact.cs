using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionarykeycollection_KeyCollectionCopyTo_KeyCollectionCopyTo_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionarykeycollection_KeyCollectionCopyTo_KeyCollectionCopyTo_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionarykeycollection\\KeyCollectionCopyTo\\KeyCollectionCopyTo.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
