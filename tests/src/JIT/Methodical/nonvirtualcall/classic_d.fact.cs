using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _nonvirtualcall_classic_d_classic_d_
    {
        [OuterLoop]
        [Fact]
        public void _nonvirtualcall_classic_d_classic_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\nonvirtualcall\\classic_d\\classic_d.cmd");
        }
    }
}
