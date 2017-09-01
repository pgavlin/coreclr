using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _JTrueLeFP_JTrueLeFP_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueLeFP_JTrueLeFP_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueLeFP\\JTrueLeFP.cmd");
        }
    }
}
