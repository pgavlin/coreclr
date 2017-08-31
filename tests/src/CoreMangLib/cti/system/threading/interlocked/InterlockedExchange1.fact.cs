using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_interlocked_InterlockedExchange1_InterlockedExchange1_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_interlocked_InterlockedExchange1_InterlockedExchange1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\interlocked\\InterlockedExchange1\\InterlockedExchange1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
