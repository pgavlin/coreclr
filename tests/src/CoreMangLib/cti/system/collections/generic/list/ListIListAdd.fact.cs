using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListIListAdd_ListIListAdd_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListIListAdd_ListIListAdd_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListIListAdd\\ListIListAdd.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
