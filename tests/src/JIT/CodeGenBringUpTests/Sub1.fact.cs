using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Sub1_Sub1_
    {
        [OuterLoop]
        [Fact]
        public void _Sub1_Sub1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Sub1\\Sub1.cmd");
        }
    }
}
