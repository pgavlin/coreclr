using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_finallytryintryfinally_r_finallytryintryfinally_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_disconnected_finallytryintryfinally_r_finallytryintryfinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\finallytryintryfinally_r\\finallytryintryfinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
