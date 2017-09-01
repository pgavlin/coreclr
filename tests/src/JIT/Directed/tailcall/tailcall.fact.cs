using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _tailcall_tailcall_tailcall_
    {
        [Fact]
        public void _tailcall_tailcall_tailcall_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\tailcall\\tailcall\\tailcall.cmd");
        }
    }
}
