using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Add1_Add1_
    {
        [OuterLoop]
        [Fact]
        public void _Add1_Add1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Add1\\Add1.cmd");
        }
    }
}
