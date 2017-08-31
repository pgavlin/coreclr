using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_reversedhandlers_d_reversedhandlers_d_
    {
        [Fact]
        public void _eh_disconnected_reversedhandlers_d_reversedhandlers_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\reversedhandlers_d\\reversedhandlers_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
