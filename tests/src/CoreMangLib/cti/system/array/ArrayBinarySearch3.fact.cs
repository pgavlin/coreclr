using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayBinarySearch3_ArrayBinarySearch3_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayBinarySearch3_ArrayBinarySearch3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayBinarySearch3\\ArrayBinarySearch3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
