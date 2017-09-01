using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_disconnected_catchbeforetrybody_r_catchbeforetrybody_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_disconnected_catchbeforetrybody_r_catchbeforetrybody_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\catchbeforetrybody_r\\catchbeforetrybody_r.cmd");
        }
    }
}
