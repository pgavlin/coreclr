using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Rotate_Rotate_
    {
        [OuterLoop]
        [Fact]
        public void _Rotate_Rotate_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Rotate\\Rotate.cmd");
        }
    }
}
