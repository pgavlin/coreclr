using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_system
{
    class _delegate_miscellaneous_ClosedStatic_ClosedStatic_
    {
        [OuterLoop]
        [Fact]
        public void _delegate_miscellaneous_ClosedStatic_ClosedStatic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\system\\delegate\\miscellaneous\\ClosedStatic\\ClosedStatic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
