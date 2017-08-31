using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _flowgraph_bug619534_twoEndFinallys_il_twoEndFinallys_il_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_bug619534_twoEndFinallys_il_twoEndFinallys_il_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\bug619534\\twoEndFinallys_il\\twoEndFinallys_il.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
