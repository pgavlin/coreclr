using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListLastIndexOf1_ListLastIndexOf1_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListLastIndexOf1_ListLastIndexOf1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListLastIndexOf1\\ListLastIndexOf1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
