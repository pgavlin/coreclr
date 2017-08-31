using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayBinarySearch2b_ArrayBinarySearch2b_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayBinarySearch2b_ArrayBinarySearch2b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayBinarySearch2b\\ArrayBinarySearch2b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
