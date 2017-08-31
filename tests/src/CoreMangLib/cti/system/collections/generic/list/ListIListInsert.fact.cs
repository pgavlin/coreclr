using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListIListInsert_ListIListInsert_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListIListInsert_ListIListInsert_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListIListInsert\\ListIListInsert.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
