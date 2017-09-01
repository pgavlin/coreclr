using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _nonvirtualcall_classic_r_classic_r_
    {
        [OuterLoop]
        [Fact]
        public void _nonvirtualcall_classic_r_classic_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\nonvirtualcall\\classic_r\\classic_r.cmd");
        }
    }
}
