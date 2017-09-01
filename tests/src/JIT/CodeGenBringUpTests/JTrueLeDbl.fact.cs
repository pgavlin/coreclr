using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _JTrueLeDbl_JTrueLeDbl_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueLeDbl_JTrueLeDbl_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueLeDbl\\JTrueLeDbl.cmd");
        }
    }
}
