using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _flowgraph_dev10_bug679955_volatileLocal1_volatileLocal1_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_dev10_bug679955_volatileLocal1_volatileLocal1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\dev10_bug679955\\volatileLocal1\\volatileLocal1.cmd");
        }
    }
}
