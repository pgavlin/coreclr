using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_interlocked_InterlockedAdd2_InterlockedAdd2_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_interlocked_InterlockedAdd2_InterlockedAdd2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\interlocked\\InterlockedAdd2\\InterlockedAdd2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
