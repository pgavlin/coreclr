using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_invocation_do_invocation_do_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_invocation_do_invocation_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\invocation_do\\invocation_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
