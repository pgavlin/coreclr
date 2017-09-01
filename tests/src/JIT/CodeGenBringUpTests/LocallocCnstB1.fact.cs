using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _LocallocCnstB1_LocallocCnstB1_
    {
        [OuterLoop]
        [Fact]
        public void _LocallocCnstB1_LocallocCnstB1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\LocallocCnstB1\\LocallocCnstB1.cmd");
        }
    }
}
