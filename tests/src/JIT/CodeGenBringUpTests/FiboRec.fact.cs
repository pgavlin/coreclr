using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FiboRec_FiboRec_
    {
        [OuterLoop]
        [Fact]
        public void _FiboRec_FiboRec_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FiboRec\\FiboRec.cmd");
        }
    }
}
