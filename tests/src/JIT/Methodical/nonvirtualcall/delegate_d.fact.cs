using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _nonvirtualcall_delegate_d_delegate_d_
    {
        [OuterLoop]
        [Fact]
        public void _nonvirtualcall_delegate_d_delegate_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\nonvirtualcall\\delegate_d\\delegate_d.cmd");
        }
    }
}
