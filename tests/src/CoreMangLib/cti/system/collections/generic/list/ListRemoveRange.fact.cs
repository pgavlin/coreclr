using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListRemoveRange_ListRemoveRange_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListRemoveRange_ListRemoveRange_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListRemoveRange\\ListRemoveRange.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
