using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_icollection_ICollectionContains_ICollectionContains_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_icollection_ICollectionContains_ICollectionContains_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\icollection\\ICollectionContains\\ICollectionContains.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
