using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _SubRef_SubRef_
    {
        [OuterLoop]
        [Fact]
        public void _SubRef_SubRef_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\SubRef\\SubRef.cmd");
        }
    }
}
