using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_BinarySearch1_BinarySearch1_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_BinarySearch1_BinarySearch1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\BinarySearch1\\BinarySearch1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
