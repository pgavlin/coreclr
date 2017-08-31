using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_invocation_r_invocation_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_invocation_r_invocation_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\invocation_r\\invocation_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
