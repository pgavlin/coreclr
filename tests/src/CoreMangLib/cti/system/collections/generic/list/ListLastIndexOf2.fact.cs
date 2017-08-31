using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListLastIndexOf2_ListLastIndexOf2_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListLastIndexOf2_ListLastIndexOf2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListLastIndexOf2\\ListLastIndexOf2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
