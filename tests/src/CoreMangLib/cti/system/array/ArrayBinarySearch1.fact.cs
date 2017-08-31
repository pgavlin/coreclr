using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayBinarySearch1_ArrayBinarySearch1_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayBinarySearch1_ArrayBinarySearch1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayBinarySearch1\\ArrayBinarySearch1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
