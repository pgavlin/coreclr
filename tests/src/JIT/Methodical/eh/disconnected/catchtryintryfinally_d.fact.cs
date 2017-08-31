using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_catchtryintryfinally_d_catchtryintryfinally_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_disconnected_catchtryintryfinally_d_catchtryintryfinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\catchtryintryfinally_d\\catchtryintryfinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
