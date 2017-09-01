using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _coverage_importer_badtailcall_badtailcall_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_importer_badtailcall_badtailcall_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\badtailcall\\badtailcall.cmd");
        }
    }
}
