using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _nonvirtualcall_generics_d_generics_d_
    {
        [OuterLoop]
        [Fact]
        public void _nonvirtualcall_generics_d_generics_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\nonvirtualcall\\generics_d\\generics_d.cmd");
        }
    }
}
