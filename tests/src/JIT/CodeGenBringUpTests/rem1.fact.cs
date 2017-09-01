using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _rem1_rem1_
    {
        [OuterLoop]
        [Fact]
        public void _rem1_rem1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\rem1\\rem1.cmd");
        }
    }
}
