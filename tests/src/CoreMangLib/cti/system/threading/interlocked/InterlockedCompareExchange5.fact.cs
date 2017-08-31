using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_interlocked_InterlockedCompareExchange5_InterlockedCompareExchange5_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_interlocked_InterlockedCompareExchange5_InterlockedCompareExchange5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\interlocked\\InterlockedCompareExchange5\\InterlockedCompareExchange5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
