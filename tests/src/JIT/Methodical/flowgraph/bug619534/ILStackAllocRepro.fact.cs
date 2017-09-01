using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _flowgraph_bug619534_ILStackAllocRepro_ILStackAllocRepro_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_bug619534_ILStackAllocRepro_ILStackAllocRepro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\bug619534\\ILStackAllocRepro\\ILStackAllocRepro.cmd");
        }
    }
}
