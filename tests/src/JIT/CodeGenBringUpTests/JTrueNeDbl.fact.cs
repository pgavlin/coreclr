using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _JTrueNeDbl_JTrueNeDbl_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueNeDbl_JTrueNeDbl_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueNeDbl\\JTrueNeDbl.cmd");
        }
    }
}
