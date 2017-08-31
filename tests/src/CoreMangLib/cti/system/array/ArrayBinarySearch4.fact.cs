using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayBinarySearch4_ArrayBinarySearch4_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayBinarySearch4_ArrayBinarySearch4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayBinarySearch4\\ArrayBinarySearch4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
