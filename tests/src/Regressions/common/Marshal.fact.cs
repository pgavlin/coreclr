using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    public class _Marshal_Marshal_
    {
        [Fact]
        public void _Marshal_Marshal_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\common\\Marshal\\Marshal.cmd");
        }
    }
}
