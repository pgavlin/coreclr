using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_interlocked_InterlockedExchange5_InterlockedExchange5_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_interlocked_InterlockedExchange5_InterlockedExchange5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\interlocked\\InterlockedExchange5\\InterlockedExchange5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
