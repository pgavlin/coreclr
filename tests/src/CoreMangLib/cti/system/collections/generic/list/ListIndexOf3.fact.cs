using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListIndexOf3_ListIndexOf3_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListIndexOf3_ListIndexOf3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListIndexOf3\\ListIndexOf3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
