using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayBinarySearch5b_ArrayBinarySearch5b_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayBinarySearch5b_ArrayBinarySearch5b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayBinarySearch5b\\ArrayBinarySearch5b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
