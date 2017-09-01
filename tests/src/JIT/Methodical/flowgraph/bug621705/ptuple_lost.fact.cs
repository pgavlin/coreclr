using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _flowgraph_bug621705_ptuple_lost_ptuple_lost_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_bug621705_ptuple_lost_ptuple_lost_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\bug621705\\ptuple_lost\\ptuple_lost.cmd");
        }
    }
}
