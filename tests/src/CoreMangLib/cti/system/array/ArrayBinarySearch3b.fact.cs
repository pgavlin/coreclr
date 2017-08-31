using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayBinarySearch3b_ArrayBinarySearch3b_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayBinarySearch3b_ArrayBinarySearch3b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayBinarySearch3b\\ArrayBinarySearch3b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
