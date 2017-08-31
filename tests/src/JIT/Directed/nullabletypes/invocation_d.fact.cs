using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_invocation_d_invocation_d_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_invocation_d_invocation_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\invocation_d\\invocation_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
