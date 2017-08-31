using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _FaultHandlers_CallOrder_CallOrder_CallOrder_
    {
        [OuterLoop]
        [Fact]
        public void _FaultHandlers_CallOrder_CallOrder_CallOrder_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\FaultHandlers\\CallOrder\\CallOrder\\CallOrder.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
