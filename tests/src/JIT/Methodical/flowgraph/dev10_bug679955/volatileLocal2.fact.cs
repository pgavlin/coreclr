using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _flowgraph_dev10_bug679955_volatileLocal2_volatileLocal2_
    {
        [Fact]
        public void _flowgraph_dev10_bug679955_volatileLocal2_volatileLocal2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\dev10_bug679955\\volatileLocal2\\volatileLocal2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
