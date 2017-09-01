using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _flowgraph_dev10_bug679053_cpblkInt32_cpblkInt32_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_dev10_bug679053_cpblkInt32_cpblkInt32_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\dev10_bug679053\\cpblkInt32\\cpblkInt32.cmd");
        }
    }
}
