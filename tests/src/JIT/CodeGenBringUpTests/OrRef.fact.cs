using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _OrRef_OrRef_
    {
        [OuterLoop]
        [Fact]
        public void _OrRef_OrRef_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\OrRef\\OrRef.cmd");
        }
    }
}
