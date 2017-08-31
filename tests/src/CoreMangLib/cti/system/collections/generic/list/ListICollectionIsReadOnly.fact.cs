using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListICollectionIsReadOnly_ListICollectionIsReadOnly_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListICollectionIsReadOnly_ListICollectionIsReadOnly_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListICollectionIsReadOnly\\ListICollectionIsReadOnly.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
