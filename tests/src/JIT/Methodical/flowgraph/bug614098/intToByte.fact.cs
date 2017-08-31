using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _flowgraph_bug614098_intToByte_intToByte_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_bug614098_intToByte_intToByte_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\bug614098\\intToByte\\intToByte.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
