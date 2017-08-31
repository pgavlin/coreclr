using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_interlocked_InterlockedCompareExchange1_InterlockedCompareExchange1_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_interlocked_InterlockedCompareExchange1_InterlockedCompareExchange1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\interlocked\\InterlockedCompareExchange1\\InterlockedCompareExchange1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
