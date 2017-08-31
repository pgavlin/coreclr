using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_icollection_ICollectionIsSynchronized_ICollectionIsSynchronized_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_icollection_ICollectionIsSynchronized_ICollectionIsSynchronized_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\icollection\\ICollectionIsSynchronized\\ICollectionIsSynchronized.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
