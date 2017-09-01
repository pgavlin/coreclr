using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _flowgraph_dev10_bug675304_arrayDim_arrayDim_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_dev10_bug675304_arrayDim_arrayDim_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\dev10_bug675304\\arrayDim\\arrayDim.cmd");
        }
    }
}
