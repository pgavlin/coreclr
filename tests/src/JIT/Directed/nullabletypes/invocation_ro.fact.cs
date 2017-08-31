using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_invocation_ro_invocation_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_invocation_ro_invocation_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\invocation_ro\\invocation_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
