using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _LocallocLarge_LocallocLarge_
    {
        [Fact]
        public void _LocallocLarge_LocallocLarge_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\LocallocLarge\\LocallocLarge.cmd");
        }
    }
}
