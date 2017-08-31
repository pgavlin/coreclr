using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListIndexOf1_ListIndexOf1_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListIndexOf1_ListIndexOf1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListIndexOf1\\ListIndexOf1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
