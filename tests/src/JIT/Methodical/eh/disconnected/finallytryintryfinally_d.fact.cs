using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_finallytryintryfinally_d_finallytryintryfinally_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_disconnected_finallytryintryfinally_d_finallytryintryfinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\finallytryintryfinally_d\\finallytryintryfinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
