using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ELEMENT_TYPE_IU__il_dbgi_flow__il_dbgi_flow_
    {
        [OuterLoop]
        [Fact]
        public void _ELEMENT_TYPE_IU__il_dbgi_flow__il_dbgi_flow_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ELEMENT_TYPE_IU\\_il_dbgi_flow\\_il_dbgi_flow.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
