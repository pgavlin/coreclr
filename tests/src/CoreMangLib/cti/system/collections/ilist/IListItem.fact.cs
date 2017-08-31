using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_ilist_IListItem_IListItem_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_ilist_IListItem_IListItem_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\ilist\\IListItem\\IListItem.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
