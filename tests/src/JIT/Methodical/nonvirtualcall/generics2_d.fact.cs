using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _nonvirtualcall_generics2_d_generics2_d_
    {
        [OuterLoop]
        [Fact]
        public void _nonvirtualcall_generics2_d_generics2_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\nonvirtualcall\\generics2_d\\generics2_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
