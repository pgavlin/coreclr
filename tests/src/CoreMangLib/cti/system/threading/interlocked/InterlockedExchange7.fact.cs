using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_interlocked_InterlockedExchange7_InterlockedExchange7_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_interlocked_InterlockedExchange7_InterlockedExchange7_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\interlocked\\InterlockedExchange7\\InterlockedExchange7.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
