using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _LeftShift_LeftShift_
    {
        [OuterLoop]
        [Fact]
        public void _LeftShift_LeftShift_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\LeftShift\\LeftShift.cmd");
        }
    }
}
