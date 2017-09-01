using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0069_date_date_
    {
        [OuterLoop]
        [Fact]
        public void _0069_date_date_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0069\\date\\date.cmd");
        }
    }
}
