using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _InstanceCalls_InstanceCalls_
    {
        [OuterLoop]
        [Fact]
        public void _InstanceCalls_InstanceCalls_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\InstanceCalls\\InstanceCalls.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
