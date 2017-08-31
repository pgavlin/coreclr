using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayBinarySearch1b_ArrayBinarySearch1b_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayBinarySearch1b_ArrayBinarySearch1b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayBinarySearch1b\\ArrayBinarySearch1b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
