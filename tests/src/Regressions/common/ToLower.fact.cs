using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    public class _ToLower_ToLower_
    {
        [Fact]
        public void _ToLower_ToLower_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\common\\ToLower\\ToLower.cmd");
        }
    }
}
