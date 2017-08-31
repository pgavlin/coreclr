using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListICollectionCopyTo_ListICollectionCopyTo_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListICollectionCopyTo_ListICollectionCopyTo_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListICollectionCopyTo\\ListICollectionCopyTo.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
