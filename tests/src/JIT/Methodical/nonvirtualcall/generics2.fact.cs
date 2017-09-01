using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _nonvirtualcall_generics2_generics2_
    {
        [OuterLoop]
        [Fact]
        public void _nonvirtualcall_generics2_generics2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\nonvirtualcall\\generics2\\generics2.cmd");
        }
    }
}
