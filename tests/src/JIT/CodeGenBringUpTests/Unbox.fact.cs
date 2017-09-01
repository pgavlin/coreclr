using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Unbox_Unbox_
    {
        [OuterLoop]
        [Fact]
        public void _Unbox_Unbox_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Unbox\\Unbox.cmd");
        }
    }
}
