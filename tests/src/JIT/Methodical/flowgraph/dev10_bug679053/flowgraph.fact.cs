using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _flowgraph_dev10_bug679053_flowgraph_flowgraph_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_dev10_bug679053_flowgraph_flowgraph_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\dev10_bug679053\\flowgraph\\flowgraph.cmd");
        }
    }
}
