using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_icollection_ICollectionIsReadOnly_ICollectionIsReadOnly_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_icollection_ICollectionIsReadOnly_ICollectionIsReadOnly_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\icollection\\ICollectionIsReadOnly\\ICollectionIsReadOnly.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
