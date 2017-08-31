using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ELEMENT_TYPE_IU__il_relu_flow__il_relu_flow_
    {
        [OuterLoop]
        [Fact]
        public void _ELEMENT_TYPE_IU__il_relu_flow__il_relu_flow_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ELEMENT_TYPE_IU\\_il_relu_flow\\_il_relu_flow.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
