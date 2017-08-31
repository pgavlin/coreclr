using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayBinarySearch4b_ArrayBinarySearch4b_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayBinarySearch4b_ArrayBinarySearch4b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayBinarySearch4b\\ArrayBinarySearch4b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
