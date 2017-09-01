using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _flowgraph_bug619534_moduleHandleCache_moduleHandleCache_
    {
        [Fact]
        public void _flowgraph_bug619534_moduleHandleCache_moduleHandleCache_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\bug619534\\moduleHandleCache\\moduleHandleCache.cmd");
        }
    }
}
