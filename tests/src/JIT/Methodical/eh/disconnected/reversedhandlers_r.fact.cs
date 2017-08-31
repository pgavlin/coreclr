using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_reversedhandlers_r_reversedhandlers_r_
    {
        [Fact]
        public void _eh_disconnected_reversedhandlers_r_reversedhandlers_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\reversedhandlers_r\\reversedhandlers_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
