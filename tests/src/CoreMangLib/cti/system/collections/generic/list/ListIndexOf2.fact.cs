using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListIndexOf2_ListIndexOf2_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListIndexOf2_ListIndexOf2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListIndexOf2\\ListIndexOf2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
