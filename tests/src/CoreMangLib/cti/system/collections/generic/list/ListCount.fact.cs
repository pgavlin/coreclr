using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListCount_ListCount_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListCount_ListCount_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListCount\\ListCount.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
