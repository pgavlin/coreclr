using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _nonvirtualcall_delegate_r_delegate_r_
    {
        [OuterLoop]
        [Fact]
        public void _nonvirtualcall_delegate_r_delegate_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\nonvirtualcall\\delegate_r\\delegate_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
