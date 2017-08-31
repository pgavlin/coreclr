using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_interlocked_InterlockedIncrement1_InterlockedIncrement1_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_interlocked_InterlockedIncrement1_InterlockedIncrement1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\interlocked\\InterlockedIncrement1\\InterlockedIncrement1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
