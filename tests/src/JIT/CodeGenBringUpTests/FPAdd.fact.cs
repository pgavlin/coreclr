using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPAdd_FPAdd_
    {
        [OuterLoop]
        [Fact]
        public void _FPAdd_FPAdd_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPAdd\\FPAdd.cmd");
        }
    }
}
