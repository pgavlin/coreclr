using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _nonvirtualcall_generics_r_generics_r_
    {
        [OuterLoop]
        [Fact]
        public void _nonvirtualcall_generics_r_generics_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\nonvirtualcall\\generics_r\\generics_r.cmd");
        }
    }
}
