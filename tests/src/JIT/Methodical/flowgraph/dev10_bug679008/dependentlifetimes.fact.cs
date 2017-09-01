using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _flowgraph_dev10_bug679008_dependentlifetimes_dependentlifetimes_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_dev10_bug679008_dependentlifetimes_dependentlifetimes_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\dev10_bug679008\\dependentlifetimes\\dependentlifetimes.cmd");
        }
    }
}
