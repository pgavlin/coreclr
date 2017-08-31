using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArraySort7_ArraySort7_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArraySort7_ArraySort7_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArraySort7\\ArraySort7.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
