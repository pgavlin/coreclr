using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_badtailcall_badtailcall_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_importer_badtailcall_badtailcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\badtailcall\\badtailcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
