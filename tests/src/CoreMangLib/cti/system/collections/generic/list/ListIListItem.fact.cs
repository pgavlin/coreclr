using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListIListItem_ListIListItem_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListIListItem_ListIListItem_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListIListItem\\ListIListItem.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
