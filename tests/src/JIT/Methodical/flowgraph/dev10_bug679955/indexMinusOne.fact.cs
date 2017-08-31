using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _flowgraph_dev10_bug679955_indexMinusOne_indexMinusOne_
    {
        [Fact]
        public void _flowgraph_dev10_bug679955_indexMinusOne_indexMinusOne_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\dev10_bug679955\\indexMinusOne\\indexMinusOne.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
