using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListIListIsFixedSize_ListIListIsFixedSize_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListIListIsFixedSize_ListIListIsFixedSize_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListIListIsFixedSize\\ListIListIsFixedSize.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
