using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _nonvirtualcall_tailcall_tailcall_
    {
        [OuterLoop]
        [Fact]
        public void _nonvirtualcall_tailcall_tailcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\nonvirtualcall\\tailcall\\tailcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
