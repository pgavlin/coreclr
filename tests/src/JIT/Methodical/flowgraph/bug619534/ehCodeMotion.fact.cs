using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _flowgraph_bug619534_ehCodeMotion_ehCodeMotion_
    {
        [Fact]
        public void _flowgraph_bug619534_ehCodeMotion_ehCodeMotion_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\bug619534\\ehCodeMotion\\ehCodeMotion.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
