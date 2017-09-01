using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _JTrueNeFP_JTrueNeFP_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueNeFP_JTrueNeFP_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueNeFP\\JTrueNeFP.cmd");
        }
    }
}
