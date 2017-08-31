using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayReverse2_ArrayReverse2_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayReverse2_ArrayReverse2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayReverse2\\ArrayReverse2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
