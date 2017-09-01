using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _LongArgsAndReturn_LongArgsAndReturn_
    {
        [OuterLoop]
        [Fact]
        public void _LongArgsAndReturn_LongArgsAndReturn_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\LongArgsAndReturn\\LongArgsAndReturn.cmd");
        }
    }
}
