using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_interlocked_InterlockedIncrement2_InterlockedIncrement2_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_interlocked_InterlockedIncrement2_InterlockedIncrement2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\interlocked\\InterlockedIncrement2\\InterlockedIncrement2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
