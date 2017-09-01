using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Localloc_Localloc_
    {
        [Fact]
        public void _Localloc_Localloc_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Localloc\\Localloc.cmd");
        }
    }
}
