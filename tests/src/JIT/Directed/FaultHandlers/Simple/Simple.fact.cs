using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _FaultHandlers_Simple_Simple_Simple_
    {
        [OuterLoop]
        [Fact]
        public void _FaultHandlers_Simple_Simple_Simple_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\FaultHandlers\\Simple\\Simple\\Simple.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
