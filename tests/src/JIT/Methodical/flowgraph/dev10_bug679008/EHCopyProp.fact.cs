using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _flowgraph_dev10_bug679008_EHCopyProp_EHCopyProp_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_dev10_bug679008_EHCopyProp_EHCopyProp_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\dev10_bug679008\\EHCopyProp\\EHCopyProp.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
