using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _ArrayMD1_ArrayMD1_
    {
        [OuterLoop]
        [Fact]
        public void _ArrayMD1_ArrayMD1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\ArrayMD1\\ArrayMD1.cmd");
        }
    }
}
