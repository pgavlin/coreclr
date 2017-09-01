using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _FaultHandlers_Nesting_Nesting_Nesting_
    {
        [OuterLoop]
        [Fact]
        public void _FaultHandlers_Nesting_Nesting_Nesting_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\FaultHandlers\\Nesting\\Nesting\\Nesting.cmd");
        }
    }
}
