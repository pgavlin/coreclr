using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayBinarySearch2_ArrayBinarySearch2_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayBinarySearch2_ArrayBinarySearch2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayBinarySearch2\\ArrayBinarySearch2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
