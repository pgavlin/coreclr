using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _JTrueGeFP_JTrueGeFP_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueGeFP_JTrueGeFP_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueGeFP\\JTrueGeFP.cmd");
        }
    }
}
