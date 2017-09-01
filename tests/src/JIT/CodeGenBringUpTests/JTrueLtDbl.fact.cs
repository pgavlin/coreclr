using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _JTrueLtDbl_JTrueLtDbl_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueLtDbl_JTrueLtDbl_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueLtDbl\\JTrueLtDbl.cmd");
        }
    }
}
