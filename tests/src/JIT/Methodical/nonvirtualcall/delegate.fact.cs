using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _nonvirtualcall_delegate_delegate_
    {
        [OuterLoop]
        [Fact]
        public void _nonvirtualcall_delegate_delegate_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\nonvirtualcall\\delegate\\delegate.cmd");
        }
    }
}
