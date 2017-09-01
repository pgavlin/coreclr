using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _nonvirtualcall_generics_generics_
    {
        [OuterLoop]
        [Fact]
        public void _nonvirtualcall_generics_generics_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\nonvirtualcall\\generics\\generics.cmd");
        }
    }
}
