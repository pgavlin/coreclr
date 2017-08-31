using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_idisposable_IDisposableDispose_IDisposableDispose_
    {
        [OuterLoop]
        [Fact]
        public void _system_idisposable_IDisposableDispose_IDisposableDispose_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\idisposable\\IDisposableDispose\\IDisposableDispose.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
