using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _IntArraySum_IntArraySum_
    {
        [OuterLoop]
        [Fact]
        public void _IntArraySum_IntArraySum_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\IntArraySum\\IntArraySum.cmd");
        }
    }
}
