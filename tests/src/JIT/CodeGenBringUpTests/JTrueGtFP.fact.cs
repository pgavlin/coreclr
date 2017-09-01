using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _JTrueGtFP_JTrueGtFP_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueGtFP_JTrueGtFP_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueGtFP\\JTrueGtFP.cmd");
        }
    }
}
