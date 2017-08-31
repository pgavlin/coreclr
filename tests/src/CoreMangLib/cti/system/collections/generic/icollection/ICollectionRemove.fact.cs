using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_icollection_ICollectionRemove_ICollectionRemove_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_icollection_ICollectionRemove_ICollectionRemove_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\icollection\\ICollectionRemove\\ICollectionRemove.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
