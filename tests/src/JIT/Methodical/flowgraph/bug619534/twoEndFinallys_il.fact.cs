using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _flowgraph_bug619534_twoEndFinallys_il_twoEndFinallys_il_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_bug619534_twoEndFinallys_il_twoEndFinallys_il_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\bug619534\\twoEndFinallys_il\\twoEndFinallys_il.cmd");
        }
    }
}
