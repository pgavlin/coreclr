using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _flowgraph_dev10_bug679008_zeroInitStackSlot_zeroInitStackSlot_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_dev10_bug679008_zeroInitStackSlot_zeroInitStackSlot_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\dev10_bug679008\\zeroInitStackSlot\\zeroInitStackSlot.cmd");
        }
    }
}
