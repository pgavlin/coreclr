using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _ArrayMD2_ArrayMD2_
    {
        [OuterLoop]
        [Fact]
        public void _ArrayMD2_ArrayMD2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\ArrayMD2\\ArrayMD2.cmd");
        }
    }
}
