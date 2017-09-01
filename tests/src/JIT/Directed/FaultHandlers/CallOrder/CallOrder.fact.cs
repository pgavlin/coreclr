using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _FaultHandlers_CallOrder_CallOrder_CallOrder_
    {
        [OuterLoop]
        [Fact]
        public void _FaultHandlers_CallOrder_CallOrder_CallOrder_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\FaultHandlers\\CallOrder\\CallOrder\\CallOrder.cmd");
        }
    }
}
