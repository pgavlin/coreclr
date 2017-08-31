using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_interlocked_InterlockedExchange6_InterlockedExchange6_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_interlocked_InterlockedExchange6_InterlockedExchange6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\interlocked\\InterlockedExchange6\\InterlockedExchange6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
