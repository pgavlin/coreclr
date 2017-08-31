using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ELEMENT_TYPE_IU__il_relu_flood__il_relu_flood_
    {
        [OuterLoop]
        [Fact]
        public void _ELEMENT_TYPE_IU__il_relu_flood__il_relu_flood_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ELEMENT_TYPE_IU\\_il_relu_flood\\_il_relu_flood.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
