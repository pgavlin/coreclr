using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_interlocked_InterlockedDecrement1_InterlockedDecrement1_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_interlocked_InterlockedDecrement1_InterlockedDecrement1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\interlocked\\InterlockedDecrement1\\InterlockedDecrement1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
