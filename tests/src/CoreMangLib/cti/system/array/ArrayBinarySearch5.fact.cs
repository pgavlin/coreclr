using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayBinarySearch5_ArrayBinarySearch5_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayBinarySearch5_ArrayBinarySearch5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayBinarySearch5\\ArrayBinarySearch5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
