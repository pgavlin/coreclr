using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayReverse1_ArrayReverse1_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayReverse1_ArrayReverse1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayReverse1\\ArrayReverse1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
