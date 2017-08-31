using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _flowgraph_bug619534_ILStackAllocRepro_ILStackAllocRepro_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_bug619534_ILStackAllocRepro_ILStackAllocRepro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\bug619534\\ILStackAllocRepro\\ILStackAllocRepro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
