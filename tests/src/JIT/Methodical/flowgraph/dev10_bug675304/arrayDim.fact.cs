using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _flowgraph_dev10_bug675304_arrayDim_arrayDim_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_dev10_bug675304_arrayDim_arrayDim_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\dev10_bug675304\\arrayDim\\arrayDim.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
