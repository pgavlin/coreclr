using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListLastIndexOf3_ListLastIndexOf3_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListLastIndexOf3_ListLastIndexOf3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListLastIndexOf3\\ListLastIndexOf3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
