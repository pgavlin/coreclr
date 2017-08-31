using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_BinarySearch2_BinarySearch2_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_BinarySearch2_BinarySearch2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\BinarySearch2\\BinarySearch2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
