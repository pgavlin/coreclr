using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListIListIsReadOnly_ListIListIsReadOnly_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListIListIsReadOnly_ListIListIsReadOnly_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListIListIsReadOnly\\ListIListIsReadOnly.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
