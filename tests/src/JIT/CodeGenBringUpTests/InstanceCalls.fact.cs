using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _InstanceCalls_InstanceCalls_
    {
        [OuterLoop]
        [Fact]
        public void _InstanceCalls_InstanceCalls_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\InstanceCalls\\InstanceCalls.cmd");
        }
    }
}
