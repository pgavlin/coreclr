using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _72162_Test72162_Test72162_
    {
        [OuterLoop]
        [Fact]
        public void _72162_Test72162_Test72162_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\72162\\Test72162\\Test72162.cmd");
        }
    }
}
