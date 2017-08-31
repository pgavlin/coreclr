using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_BinarySearch3_BinarySearch3_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_BinarySearch3_BinarySearch3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\BinarySearch3\\BinarySearch3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
