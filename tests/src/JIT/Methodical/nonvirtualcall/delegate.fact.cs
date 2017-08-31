using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _nonvirtualcall_delegate_delegate_
    {
        [OuterLoop]
        [Fact]
        public void _nonvirtualcall_delegate_delegate_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\nonvirtualcall\\delegate\\delegate.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
