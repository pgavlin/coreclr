using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_disconnected_finallytryintryfinally_r_finallytryintryfinally_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_disconnected_finallytryintryfinally_r_finallytryintryfinally_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\finallytryintryfinally_r\\finallytryintryfinally_r.cmd");
        }
    }
}
