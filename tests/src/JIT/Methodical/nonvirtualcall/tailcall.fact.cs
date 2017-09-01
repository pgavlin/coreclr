using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _nonvirtualcall_tailcall_tailcall_
    {
        [OuterLoop]
        [Fact]
        public void _nonvirtualcall_tailcall_tailcall_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\nonvirtualcall\\tailcall\\tailcall.cmd");
        }
    }
}
