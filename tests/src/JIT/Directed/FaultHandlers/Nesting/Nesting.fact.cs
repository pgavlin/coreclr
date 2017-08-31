using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _FaultHandlers_Nesting_Nesting_Nesting_
    {
        [OuterLoop]
        [Fact]
        public void _FaultHandlers_Nesting_Nesting_Nesting_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\FaultHandlers\\Nesting\\Nesting\\Nesting.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
