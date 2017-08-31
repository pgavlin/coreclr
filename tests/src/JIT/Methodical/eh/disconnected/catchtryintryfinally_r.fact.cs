using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_catchtryintryfinally_r_catchtryintryfinally_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_disconnected_catchtryintryfinally_r_catchtryintryfinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\catchtryintryfinally_r\\catchtryintryfinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
