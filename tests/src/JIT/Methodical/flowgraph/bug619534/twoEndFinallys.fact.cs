using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _flowgraph_bug619534_twoEndFinallys_twoEndFinallys_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_bug619534_twoEndFinallys_twoEndFinallys_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\bug619534\\twoEndFinallys\\twoEndFinallys.cmd");
        }
    }
}
