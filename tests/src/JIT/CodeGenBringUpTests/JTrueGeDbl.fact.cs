using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _JTrueGeDbl_JTrueGeDbl_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueGeDbl_JTrueGeDbl_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueGeDbl\\JTrueGeDbl.cmd");
        }
    }
}
