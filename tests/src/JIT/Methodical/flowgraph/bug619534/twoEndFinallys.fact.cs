using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _flowgraph_bug619534_twoEndFinallys_twoEndFinallys_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_bug619534_twoEndFinallys_twoEndFinallys_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\bug619534\\twoEndFinallys\\twoEndFinallys.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
