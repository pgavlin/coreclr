using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_ilist_IListItem_IListItem_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_ilist_IListItem_IListItem_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\ilist\\IListItem\\IListItem.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
