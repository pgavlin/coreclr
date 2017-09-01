using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_disconnected_catchtryintryfinally_r_catchtryintryfinally_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_disconnected_catchtryintryfinally_r_catchtryintryfinally_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\catchtryintryfinally_r\\catchtryintryfinally_r.cmd");
        }
    }
}
