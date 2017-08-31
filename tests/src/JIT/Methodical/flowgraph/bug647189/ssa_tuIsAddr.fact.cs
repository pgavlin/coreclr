using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _flowgraph_bug647189_ssa_tuIsAddr_ssa_tuIsAddr_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_bug647189_ssa_tuIsAddr_ssa_tuIsAddr_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\bug647189\\ssa_tuIsAddr\\ssa_tuIsAddr.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
