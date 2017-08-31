using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _flowgraph_bug621705_ptuple_lost_ptuple_lost_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_bug621705_ptuple_lost_ptuple_lost_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\bug621705\\ptuple_lost\\ptuple_lost.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
