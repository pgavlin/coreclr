using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ELEMENT_TYPE_IU__il_reli_flow__il_reli_flow_
    {
        [OuterLoop]
        [Fact]
        public void _ELEMENT_TYPE_IU__il_reli_flow__il_reli_flow_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ELEMENT_TYPE_IU\\_il_reli_flow\\_il_reli_flow.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
