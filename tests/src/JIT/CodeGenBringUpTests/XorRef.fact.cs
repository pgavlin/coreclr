using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _XorRef_XorRef_
    {
        [OuterLoop]
        [Fact]
        public void _XorRef_XorRef_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\XorRef\\XorRef.cmd");
        }
    }
}
