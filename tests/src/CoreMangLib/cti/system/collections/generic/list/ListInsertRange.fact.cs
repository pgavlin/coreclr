using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListInsertRange_ListInsertRange_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListInsertRange_ListInsertRange_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListInsertRange\\ListInsertRange.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
