using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayBinarySearch6_ArrayBinarySearch6_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayBinarySearch6_ArrayBinarySearch6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayBinarySearch6\\ArrayBinarySearch6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
