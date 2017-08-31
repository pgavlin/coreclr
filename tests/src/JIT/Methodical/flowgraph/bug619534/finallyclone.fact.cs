using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _flowgraph_bug619534_finallyclone_finallyclone_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_bug619534_finallyclone_finallyclone_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\bug619534\\finallyclone\\finallyclone.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
