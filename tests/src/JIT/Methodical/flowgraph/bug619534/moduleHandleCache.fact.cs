using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _flowgraph_bug619534_moduleHandleCache_moduleHandleCache_
    {
        [Fact]
        public void _flowgraph_bug619534_moduleHandleCache_moduleHandleCache_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\bug619534\\moduleHandleCache\\moduleHandleCache.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
