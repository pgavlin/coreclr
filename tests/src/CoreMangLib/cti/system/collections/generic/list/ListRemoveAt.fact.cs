using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListRemoveAt_ListRemoveAt_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListRemoveAt_ListRemoveAt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListRemoveAt\\ListRemoveAt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
