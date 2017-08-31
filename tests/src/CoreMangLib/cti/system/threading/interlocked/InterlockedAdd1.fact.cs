using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_interlocked_InterlockedAdd1_InterlockedAdd1_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_interlocked_InterlockedAdd1_InterlockedAdd1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\interlocked\\InterlockedAdd1\\InterlockedAdd1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
