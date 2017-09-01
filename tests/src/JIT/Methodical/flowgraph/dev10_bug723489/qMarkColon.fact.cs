using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _flowgraph_dev10_bug723489_qMarkColon_qMarkColon_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_dev10_bug723489_qMarkColon_qMarkColon_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\dev10_bug723489\\qMarkColon\\qMarkColon.cmd");
        }
    }
}
