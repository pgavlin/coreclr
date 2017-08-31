using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayReserse2_ArrayReserse2_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayReserse2_ArrayReserse2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayReserse2\\ArrayReserse2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
