using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArraySort11_ArraySort11_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArraySort11_ArraySort11_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArraySort11\\ArraySort11.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
