using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _flowgraph_bug614098_intToByte_intToByte_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_bug614098_intToByte_intToByte_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\bug614098\\intToByte\\intToByte.cmd");
        }
    }
}
