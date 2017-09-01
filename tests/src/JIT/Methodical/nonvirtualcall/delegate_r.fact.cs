using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _nonvirtualcall_delegate_r_delegate_r_
    {
        [OuterLoop]
        [Fact]
        public void _nonvirtualcall_delegate_r_delegate_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\nonvirtualcall\\delegate_r\\delegate_r.cmd");
        }
    }
}
