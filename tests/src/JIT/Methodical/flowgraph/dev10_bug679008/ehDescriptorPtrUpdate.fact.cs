using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _flowgraph_dev10_bug679008_ehDescriptorPtrUpdate_ehDescriptorPtrUpdate_
    {
        [Fact]
        public void _flowgraph_dev10_bug679008_ehDescriptorPtrUpdate_ehDescriptorPtrUpdate_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\dev10_bug679008\\ehDescriptorPtrUpdate\\ehDescriptorPtrUpdate.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
