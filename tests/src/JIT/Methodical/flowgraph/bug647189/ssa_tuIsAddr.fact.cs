using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _flowgraph_bug647189_ssa_tuIsAddr_ssa_tuIsAddr_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_bug647189_ssa_tuIsAddr_ssa_tuIsAddr_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\bug647189\\ssa_tuIsAddr\\ssa_tuIsAddr.cmd");
        }
    }
}
