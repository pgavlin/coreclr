using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_interlocked_InterlockedDecrement2_InterlockedDecrement2_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_interlocked_InterlockedDecrement2_InterlockedDecrement2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\interlocked\\InterlockedDecrement2\\InterlockedDecrement2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
