using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_interlocked_InterlockedCompareExchange6_InterlockedCompareExchange6_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_interlocked_InterlockedCompareExchange6_InterlockedCompareExchange6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\interlocked\\InterlockedCompareExchange6\\InterlockedCompareExchange6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
