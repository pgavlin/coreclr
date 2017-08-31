using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_icollection_ICollectionAdd_ICollectionAdd_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_icollection_ICollectionAdd_ICollectionAdd_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\icollection\\ICollectionAdd\\ICollectionAdd.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
