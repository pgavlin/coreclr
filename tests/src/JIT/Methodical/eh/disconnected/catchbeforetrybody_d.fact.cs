using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_catchbeforetrybody_d_catchbeforetrybody_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_disconnected_catchbeforetrybody_d_catchbeforetrybody_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\catchbeforetrybody_d\\catchbeforetrybody_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
