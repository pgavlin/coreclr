using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _JTrue1_JTrue1_
    {
        [OuterLoop]
        [Fact]
        public void _JTrue1_JTrue1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrue1\\JTrue1.cmd");
        }
    }
}
