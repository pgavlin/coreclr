using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_Desktop_badtailcall_il_d_badtailcall_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_importer_Desktop_badtailcall_il_d_badtailcall_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\Desktop\\badtailcall_il_d\\badtailcall_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
