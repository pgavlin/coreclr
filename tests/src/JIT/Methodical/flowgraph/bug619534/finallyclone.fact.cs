using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _flowgraph_bug619534_finallyclone_finallyclone_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_bug619534_finallyclone_finallyclone_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\bug619534\\finallyclone\\finallyclone.cmd");
        }
    }
}
