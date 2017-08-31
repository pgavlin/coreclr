using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_interlocked_InterlockedCompareExchange7_InterlockedCompareExchange7_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_interlocked_InterlockedCompareExchange7_InterlockedCompareExchange7_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\interlocked\\InterlockedCompareExchange7\\InterlockedCompareExchange7.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
