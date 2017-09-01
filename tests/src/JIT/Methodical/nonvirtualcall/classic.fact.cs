using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _nonvirtualcall_classic_classic_
    {
        [OuterLoop]
        [Fact]
        public void _nonvirtualcall_classic_classic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\nonvirtualcall\\classic\\classic.cmd");
        }
    }
}
