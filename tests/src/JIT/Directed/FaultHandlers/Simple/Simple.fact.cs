using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _FaultHandlers_Simple_Simple_Simple_
    {
        [OuterLoop]
        [Fact]
        public void _FaultHandlers_Simple_Simple_Simple_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\FaultHandlers\\Simple\\Simple\\Simple.cmd");
        }
    }
}
